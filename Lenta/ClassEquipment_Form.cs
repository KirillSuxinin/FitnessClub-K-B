using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub.Lenta
{
    public partial class ClassEquipment_Form : Form
    {
        public ClassEquipment_Form()
        {
            InitializeComponent();
            dynamic_style.Enable(this);
        }

        private void classEquipmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.classEquipmentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.fitnessClubDataSet);
                MessageBox.Show(this, "Сохранение успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка сохранения!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                classEquipmentBindingSource.CancelEdit();
            }
        }

        private void ClassEquipment_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Trainers". При необходимости она может быть перемещена или удалена.
            this.trainersTableAdapter.Fill(this.fitnessClubDataSet.Trainers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter.Fill(this.fitnessClubDataSet.Equipment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.fitnessClubDataSet.Classes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.ClassEquipment". При необходимости она может быть перемещена или удалена.
            this.classEquipmentTableAdapter.Fill(this.fitnessClubDataSet.ClassEquipment);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            classEquipmentBindingSource.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            classEquipmentBindingSource.MovePrevious();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            classEquipmentBindingSource.CancelEdit();

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            classEquipmentBindingSource.MoveNext();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            classEquipmentBindingSource.MoveLast();
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
                        classEquipmentBindingNavigatorSaveItem?.PerformClick();
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
                classEquipmentIDTextBox.Text = newUID.ToString();

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

                classEquipmentBindingNavigatorSaveItem.PerformClick();
                //MessageBox.Show(this, "Данные сохранены успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка сохранения!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            try
            {
                Tables.Table_Common_Handler handler = new Tables.Table_Common_Handler("ClassEquipment");
                handler.Show(this);

            }catch(Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void classEquipmentBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {

            
        }


        private void fitnessClubDataSet_MergeFailed(object sender, MergeFailedEventArgs e)
        {

        }

        private void btnSortWith_Click(object sender, EventArgs e)
        {
            

            try
            {
                var cmd = Program.SERVER_SQL.CreateCommand();
                cmd.CommandText = "select ClassEquipmentID,ClassEquipment.ClassID,ClassEquipment.EquipmentID as EQUID,Classes.Name,DayOfWeek,Equipment.Name as EQUINAME,Equipment.Type from ClassEquipment JOIN Classes ON (ClassEquipment.ClassID = Classes.ClassID) JOIN Equipment ON (ClassEquipment.EquipmentID = Equipment.EquipmentID)";
                Tables.Table_Common_Handler handler = new Tables.Table_Common_Handler(cmd);
                handler.Show(this);

            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
