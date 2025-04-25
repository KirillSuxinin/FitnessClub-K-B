using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub.Lenta
{
    public partial class Trainers_Form : Form
    {
        public Trainers_Form()
        {
            InitializeComponent();
            dynamic_style.Enable(this);
        }

        private void trainersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.trainersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.fitnessClubDataSet);
                MessageBox.Show(this, "Сохранение успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception g)
            {
                MessageBox.Show(this, "Не удалось применить сохранения!\n" + g.Message + "\nИзменения будут отменены!", "Критическая ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                trainersBindingSource.CancelEdit();
            }

        }

        private void Trainers_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Images". При необходимости она может быть перемещена или удалена.
            this.imagesTableAdapter.Fill(this.fitnessClubDataSet.Images);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.ClassEquipment". При необходимости она может быть перемещена или удалена.
            this.classEquipmentTableAdapter.Fill(this.fitnessClubDataSet.ClassEquipment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.fitnessClubDataSet.Classes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Trainers". При необходимости она может быть перемещена или удалена.
            this.trainersTableAdapter.Fill(this.fitnessClubDataSet.Trainers);

        }

        private void Initialize_ListClassesTrainers()
        {
         //   lst_classes_by_trainers.Items.Clear();
         //   lst_classes_by_trainers.ForeColor = Color.Black;
            var data = Program.Select_Dynamic($"SELECT * FROM [Classes] WHERE [TrainerID] = \'{(trainersBindingSource.Current as DataRowView).Row.ItemArray[0]}\'");
            if(((int)(data.Count) > 0))
            {
                dataGrid_classe_by_trainer.Columns.Clear();
                dataGrid_classe_by_trainer.Rows.Clear();
                dataGrid_classe_by_trainer.DataSource = null;
                dataGrid_classe_by_trainer.Columns.Add("Наименование", "Наименование");
                dataGrid_classe_by_trainer.Columns.Add("День недели","День недели");
                dataGrid_classe_by_trainer.Columns.Add("Начало", "Начало");
                dataGrid_classe_by_trainer.Columns.Add("Окончание", "Окончание");
                dataGrid_classe_by_trainer.RowsDefaultCellStyle.SelectionBackColor = this.BackColor;
                foreach (var din in data)
                {
                    dataGrid_classe_by_trainer.Rows.Add(din.Name.ToString(),din.DayOfWeek.ToString(),din.StartTime.ToString(),din.EndTime.ToString());
                }
                dataGrid_classe_by_trainer.ClearSelection();
            }
            else
            {
                dataGrid_classe_by_trainer.Columns.Clear();
                dataGrid_classe_by_trainer.Rows.Clear();
                dataGrid_classe_by_trainer.Columns.Add("", "");
                int index = dataGrid_classe_by_trainer.Rows.Add("Занятия отсутствуют");
                dataGrid_classe_by_trainer.RowsDefaultCellStyle.SelectionBackColor = Color.Red;
                dataGrid_classe_by_trainer.Rows[index].Cells[0].Style.BackColor = Color.Red;
                dataGrid_classe_by_trainer.ClearSelection();
                
            }
        }

        private void trainersBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            Initialize_ListClassesTrainers();
        }

        private void dataGrid_classe_by_trainer_SizeChanged(object sender, EventArgs e)
        {
            Initialize_ListClassesTrainers();
        }

        private void trainersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Initialize_ListClassesTrainers();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            Tables.Table_Common_Handler train = new Tables.Table_Common_Handler("Trainers");
            train.Show(this);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            trainersBindingSource.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            trainersBindingSource.MovePrevious();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            trainersBindingSource.MoveNext();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            trainersBindingSource.MoveLast();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            trainersBindingSource.CancelEdit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Вы уверены что хотите удалить запись?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bindingNavigatorDeleteItem.PerformClick();
                    if(MessageBox.Show(this,"Применить удаление?\nЭто действие нельзя будет вернуть","Применить?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        trainersBindingNavigatorSaveItem?.PerformClick();
                       // MessageBox.Show(this, "Сохранение успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }catch(Exception g)
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
                trainerIDComboBox.Text = newUID.ToString();

            }
            catch(Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка добавления!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                trainersBindingNavigatorSaveItem?.PerformClick();
                //MessageBox.Show(this, "Данные сохранены успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка сохранения!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {

        }

        private void trainersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            if (!string.IsNullOrWhiteSpace(imgCombo.Text))
            {
                if (Program.Images.Where(x => x.Key.ToString() == imgCombo.Text).Count() > 0)
                    pictureBox1.Image = Program.Images[int.Parse(imgCombo.Text)];
            }
        }

        private void imgCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            if (!string.IsNullOrWhiteSpace(imgCombo.Text))
            {
                if (Program.Images.Where(x => x.Key.ToString() == imgCombo.Text).Count() > 0)
                    pictureBox1.Image = Program.Images[int.Parse(imgCombo.Text)];
            }
        }
    }
}
