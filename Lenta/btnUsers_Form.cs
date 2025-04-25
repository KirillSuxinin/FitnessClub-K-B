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
    public partial class Users_Form : Form
    {
        public Users_Form()
        {
            InitializeComponent();
            dynamic_style.Enable(this);
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.fitnessClubDataSet);
                MessageBox.Show(this, "Данные сохранены успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception g)
            {
                MessageBox.Show(this, "Не удалось применить сохранения!\n" + g.Message + "\nИзменения будут отменены!", "Критическая ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usersBindingSource.CancelEdit();
            }

        }

        private void Users_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.fitnessClubDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.fitnessClubDataSet.Users);

        }

        private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                if (Program.Images.Where(x => x.Key.ToString() == comboBox1.Text).Count() > 0)
                    pictureBox1.Image = Program.Images[int.Parse(comboBox1.Text)];
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            Tables.Table_Common_Handler sort = new Tables.Table_Common_Handler("Users");
            sort.Show(this);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            usersBindingSource.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            usersBindingSource.MovePrevious();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            usersBindingSource.CancelEdit();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            usersBindingSource.MoveNext();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            usersBindingSource.MoveLast();
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
                        usersBindingNavigatorSaveItem?.PerformClick();
                        //   MessageBox.Show(this, "Сохранение успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                iD_UserComboBox.Text = newUID.ToString();

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
                usersBindingNavigatorSaveItem?.PerformClick();
                // MessageBox.Show(this, "Данные сохранены успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка сохранения!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
