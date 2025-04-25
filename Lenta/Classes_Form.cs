using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub.Lenta
{
    public partial class Classes_Form : Form
    {
        public Classes_Form()
        {
            InitializeComponent();
            dynamic_style.Enable(this);
        }

        private void classesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.classesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.fitnessClubDataSet);
                MessageBox.Show(this, "Сохранение успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception g)
            {
                MessageBox.Show(this, "Не удалось применить сохранения!\n"+g.Message+"\nИзменения будут отменены!", "Критическая ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                classesBindingSource.CancelEdit();
            }

        }

        private void Classes_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Trainers". При необходимости она может быть перемещена или удалена.
            this.trainersTableAdapter.Fill(this.fitnessClubDataSet.Trainers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.fitnessClubDataSet.Classes);

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            classesBindingSource.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            classesBindingSource.MovePrevious();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            classesBindingSource.MoveNext();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            classesBindingSource.MoveLast();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            classesBindingSource.CancelEdit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            Tables.Table_Common_Handler classes = new Tables.Table_Common_Handler("Classes");
            classes.Show(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Вы уверены что хотите удалить запись?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bindingNavigatorDeleteItem.PerformClick();
                    if (MessageBox.Show(this, "Применить удаление?\nЭто действие нельзя будет вернуть", "Применить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        classesBindingNavigatorSaveItem?.PerformClick();
                       // MessageBox.Show(this, "Сохранение успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка удаления!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                bindingNavigatorAddNewItem?.PerformClick();
                int newUID = int.Parse(bindingNavigatorPositionItem.Text);
                classIDComboBox.Text = newUID.ToString();

            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка добавления!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                classesBindingNavigatorSaveItem?.PerformClick();
                //MessageBox.Show(this, "Данные сохранены успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка сохранения!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_registrationOnClasses_Click(object sender, EventArgs e)
        {
            int ClientID = Properties.Settings.Default.ID;
            if(ClientID == -1)
            {
                MessageBox.Show(this, "Пользователь для записи не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ClassesID = int.Parse((classesBindingSource.Current as DataRowView).Row.ItemArray[0].ToString());
            var dataSchedule = Program.Select_Dynamic($"SELECT * FROM [ClassSchedules] WHERE [ClassID] = \'{ClassesID}\'");
            bool wasRegistration = false;
            if(dataSchedule != null)
            {
                foreach(var schedule in dataSchedule)
                {
                    var clientRegistration = Program.Select_Dynamic($"SELECT * FROM [ClientClassRegistrations] WHERE [ClientID] = \'{ClientID}\' and [ClassScheduleID] = \'{schedule.ClassScheduleID.ToString()}\'");
                    if((int)(clientRegistration.Count) > 0)
                    {
                        wasRegistration = true;
                        MessageBox.Show(this, $"Данный пользователь был записан в \'{clientRegistration[0].RegisteredAt.ToString()}\'", "Ошибка записи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }



            if (!wasRegistration)
            {
                if(MessageBox.Show(this,$"Вы уверены что хотите записаться на \'{(classesBindingSource.Current as DataRowView).Row.ItemArray[1]}\'","Подтвердите",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int schedules_id_new = Program.GetMaxID("ClassSchedules", "ClassScheduleID")+1;
                    int schedule_result = Program.Insert($"INSERT INTO [ClassSchedules] VALUES({schedules_id_new},{ClassesID},\'{System.DateTime.Now.ToShortDateString()}\')");
                    if(schedule_result == 1)
                    {
                        int registration_id_new = Program.GetMaxID("ClientClassRegistrations","RegistrationID")+1;
                        int registration_result = Program.Insert($"INSERT INTO [ClientClassRegistrations] VALUES({registration_id_new},{ClientID},{schedules_id_new},\'{System.DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}\')");
                        if(registration_result == 1)
                        {
                            MessageBox.Show(this, "Вы успешно записаны на занятие!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "Запись [ClientClassRegistrations] вернула: " + registration_result.ToString() + "\nОбратитесь к администратору системы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Запись [ClassSchedules] вернула: " + schedule_result.ToString() + "\nОбратитесь к администратору системы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
