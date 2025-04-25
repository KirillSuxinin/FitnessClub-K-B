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
    public partial class Payments_Form : Form
    {
        public Payments_Form()
        {
            InitializeComponent();
            dynamic_style.Enable(this);
        }

        private void paymentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.paymentsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.fitnessClubDataSet);
                MessageBox.Show(this, "Сохранение успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception g)
            {
                MessageBox.Show(this, "Не удалось применить сохранения!\n" + g.Message + "\nИзменения будут отменены!", "Критическая ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paymentsBindingSource.CancelEdit();
            }
        }

        private void Payments_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.MembershipTypes". При необходимости она может быть перемещена или удалена.
            this.membershipTypesTableAdapter.Fill(this.fitnessClubDataSet.MembershipTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.fitnessClubDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Memberships". При необходимости она может быть перемещена или удалена.
            this.membershipsTableAdapter.Fill(this.fitnessClubDataSet.Memberships);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Payments". При необходимости она может быть перемещена или удалена.
            this.paymentsTableAdapter.Fill(this.fitnessClubDataSet.Payments);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            try
            {
                Tables.Table_Common_Handler handler = new Tables.Table_Common_Handler("Payments");
                handler.Show(this);
            }
            catch
            {

            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            paymentsBindingSource.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            paymentsBindingSource.MovePrevious();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            paymentsBindingSource.CancelEdit();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            paymentsBindingSource.MoveNext();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            paymentsBindingSource.MoveLast();
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
                        paymentsBindingNavigatorSaveItem?.PerformClick();
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
                paymentIDComboBox.Text = newUID.ToString();

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
                paymentsBindingNavigatorSaveItem?.PerformClick();
                //MessageBox.Show(this, "Данные сохранены успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка сохранения!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
