using System;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessClub.Other
{
    public partial class MeClasses_Form : Form
    {
        public MeClasses_Form()
        {
            InitializeComponent();
            dynamic_style.Enable(this);
        }

        dynamic ME_DATA;

        private void MeClasses_Form_Load(object sender, EventArgs e)
        {

            int ID = Properties.Settings.Default.ID;
            ME_DATA = Program.Select_Dynamic($"SELECT * FROM [ClientClassRegistrations] JOIN ClassSchedules ON (ClientClassRegistrations.ClassScheduleID = ClassSchedules.ClassScheduleID) JOIN [Classes] ON (ClassSchedules.ClassID = Classes.ClassID) JOIN [Trainers] ON (Classes.TrainerID = Trainers.TrainerID) WHERE ClientClassRegistrations.ClientID = \'{ID}\'");
            int count_classes = ME_DATA.Count;
            lst_classes.Items.Clear();
            chartGrid1.AxisX_Key.Clear();
            chartGrid1.AxisY_Key.Clear();
            for (int i = 0; i < count_classes; i++)
            {
                lst_classes.Items.Add($"{ME_DATA[i].Name}");
            }

            //РАБОТА С ГРАФИКОМ
            //График отображает дни недели, часы занятия
            
            for(int i = 0; i < 14; i++)
            {//10 - 17
                chartGrid1.AxisX_Key.Add($"{7 + i}:00");
            }

            chartGrid1.AxisY_Key.Add("Понедельник");
            chartGrid1.AxisY_Key.Add("Вторник");

            chartGrid1.AxisY_Key.Add("Среда");
            chartGrid1.AxisY_Key.Add("Четверг");

            chartGrid1.AxisY_Key.Add("Пятница");
            chartGrid1.AxisY_Key.Add("Суббота");
            chartGrid1.Refresh();
            foreach(var me in ME_DATA)
            {
                TimeSpan startTime = TimeSpan.Parse(me.StartTime.ToString());
                TimeSpan endTime = TimeSpan.Parse(me.EndTime.ToString())-TimeSpan.FromHours(1);

                for(TimeSpan inter = startTime; inter <= endTime; inter += TimeSpan.FromHours(1))
                {
                    
                    chartGrid1.SetUniqueData($"{inter.Hours}:00", me.DayOfWeek.ToString(), Color.Blue,me.ClassID.ToString(), me.Name.ToString());
                }
            }
            chartGrid1.MouseClickChart += (Id_Class) =>
            {
                int ClassID = int.Parse(Id_Class.ToString());
                foreach(var v in ME_DATA)
                {
                    if(ClassID == int.Parse(v.ClassID.ToString()))
                    {
                        for(int j = 0; j < lst_classes.Items.Count; j++)
                        {

                            if (lst_classes.Items[j].ToString().ToUpper() == v.Name.ToString().ToUpper())
                            {
                                lst_classes.SelectedIndex = j;
                                break;
                            }
                        }
                    }
                }
            };
            ContextMenu change = new ContextMenu();

            MenuItem add_menu = new MenuItem("Добавить");
            add_menu.Click += (_sender, _e) =>
            {
                Lenta.Classes_Form fs = new Lenta.Classes_Form();
                fs.ShowDialog(this);
                MeClasses_Form_Load(sender, e);
            };

            MenuItem del_menu = new MenuItem("Удалить");
            del_menu.Click += (_sender, _e) =>
            {
                if(lst_classes.SelectedIndex != -1)
                {
                    string name = lst_classes.SelectedItem.ToString();
                    if(MessageBox.Show(this,$"Вы уверены что хотите удалить \'{name}\' из своего графика?","Подтвердите",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int idClass = -1;
                        foreach(var V in ME_DATA)
                        {
                            if(V.Name.ToString().ToUpper() == name.ToUpper())
                            {
                                idClass = (int)V.ClassID;
                            }
                        }
                        if(idClass != -1)
                        {
                            int idClient = Properties.Settings.Default.ID;
                            if(idClient != -1)
                            {
                                var ClassSchedule = Program.Select_Dynamic($"SELECT * FROM [ClassSchedules] WHERE [ClassID] = \'{idClass}\'");
                                foreach(var schedule in ClassSchedule)
                                {
                                    var ClientClassRegistration = Program.Select_Dynamic($"SELECT * FROM [ClientClassRegistrations] WHERE [ClientID] = \'{idClient}\' and [ClassScheduleID] = \'{schedule.ClassScheduleID}\'");
                                    if((int)(ClientClassRegistration.Count) > 0)
                                    {

                                       // MessageBox.Show($"{ClientClassRegistration[0].RegistrationID} {ClientClassRegistration[0].ClassScheduleID}");
                                        int del_reg = Program.Insert($"DELETE FROM [ClientClassRegistrations] WHERE [RegistrationID] = \'{ClientClassRegistration[0].RegistrationID}\'");
                                        int del_schedule = Program.Insert($"DELETE FROM [ClassSchedules] WHERE [ClassScheduleID] = \'{ClientClassRegistration[0].ClassScheduleID}\'");
                                        if(del_reg == 1 && del_schedule == 1)
                                        {
                                            MessageBox.Show(this, "Изменения сохранены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            MeClasses_Form_Load(sender,e);
                                        }
                                        else
                                        {
                                            MessageBox.Show(this, $"Ошибка транзакции!\ndel_reg: {del_reg}\ndel_schedule: {del_schedule}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            MeClasses_Form_Load(sender, e);

                                        }
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            };
            change.MenuItems.Add(add_menu);
            change.MenuItems.Add(del_menu);

            lst_classes.ContextMenu = change;
            chartGrid1.ContextMenu = change;

        }

        private void lst_classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lst_classes.SelectedIndex != -1)
            {
                var that = ME_DATA[lst_classes.SelectedIndex];
                txtNameSurnameTrainer.Text = $"{that.FirstName} {that.LastName}";
                txtNumberTrainer.Text = $"{that.Phone}";
                txtEmailTrainer.Text = $"{that.Email}";
                txtStart.Text = $"{that.StartTime}";
                txtEnd.Text = $"{that.EndTime}";
                txtDayOfWeeks.Text = $"{that.DayOfWeek}";
                txtSpecialization.Text = $"{that.Specialization}";

                foreach (var me in ME_DATA)
                {
                    TimeSpan startTime = TimeSpan.Parse(me.StartTime.ToString());
                    TimeSpan endTime = TimeSpan.Parse(me.EndTime.ToString()) - TimeSpan.FromHours(1);

                    for (TimeSpan inter = startTime; inter <= endTime; inter += TimeSpan.FromHours(1))
                    {
                        if (me == that)
                        {
                            chartGrid1.SetUniqueData($"{inter.Hours}:00", me.DayOfWeek.ToString(), Color.Lime, me.ClassID.ToString(), me.Name.ToString());
                        }
                        else
                            chartGrid1.SetUniqueData($"{inter.Hours}:00", me.DayOfWeek.ToString(), Color.Blue, me.ClassID.ToString(), me.Name.ToString());
                    }
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
