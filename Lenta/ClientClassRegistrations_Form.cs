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
    public partial class ClientClassRegistrations_Form : Form
    {
        public ClientClassRegistrations_Form()
        {
            InitializeComponent();
            dynamic_style.Enable(this);
        }

        private void clientClassRegistrationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientClassRegistrationsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.fitnessClubDataSet);
                MessageBox.Show(this, "Данные сохранены успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception g)
            {
                MessageBox.Show(this, "Не удалось применить сохранения!\n" + g.Message + "\nИзменения будут отменены!", "Критическая ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clientClassRegistrationsBindingSource.CancelEdit();
            }

        }

        private void ClientClassRegistrations_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.ClassSchedules". При необходимости она может быть перемещена или удалена.
            this.classSchedulesTableAdapter.Fill(this.fitnessClubDataSet.ClassSchedules);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.fitnessClubDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.ClientClassRegistrations". При необходимости она может быть перемещена или удалена.
            this.clientClassRegistrationsTableAdapter.Fill(this.fitnessClubDataSet.ClientClassRegistrations);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            Tables.Table_Common_Handler sort = new Tables.Table_Common_Handler("ClientClassRegistrations");
            sort.Show(this);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            clientClassRegistrationsBindingSource.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            clientClassRegistrationsBindingSource.MovePrevious();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clientClassRegistrationsBindingSource.CancelEdit();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            clientClassRegistrationsBindingSource.MoveNext();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            clientClassRegistrationsBindingSource.MoveLast();
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
                        clientClassRegistrationsBindingNavigatorSaveItem?.PerformClick();
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
                registrationIDComboBox.Text = newUID.ToString();

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
                clientClassRegistrationsBindingNavigatorSaveItem?.PerformClick();
                // MessageBox.Show(this, "Данные сохранены успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка сохранения!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
