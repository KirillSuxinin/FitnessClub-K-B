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
    public partial class Membershis_Form : Form
    {
        public Membershis_Form()
        {
            InitializeComponent();
            dynamic_style.Enable(this);
        }

        private void membershipsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.membershipsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.fitnessClubDataSet);
                MessageBox.Show(this, "Сохранение успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception g)
            {
                MessageBox.Show(this, "Не удалось применить сохранения!\n" + g.Message + "\nИзменения будут отменены!", "Критическая ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                membershipsBindingSource.CancelEdit();
            }
        }

        private void Membershis_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.MembershipTypes". При необходимости она может быть перемещена или удалена.
            this.membershipTypesTableAdapter.Fill(this.fitnessClubDataSet.MembershipTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.fitnessClubDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Memberships". При необходимости она может быть перемещена или удалена.
            this.membershipsTableAdapter.Fill(this.fitnessClubDataSet.Memberships);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            Tables.Table_Common_Handler handler = new Tables.Table_Common_Handler("Memberships");
            handler.Show(this);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            membershipsBindingSource.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            membershipsBindingSource.MovePrevious();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            membershipsBindingSource.CancelEdit();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            membershipsBindingSource.MoveNext();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            membershipsBindingSource.MoveLast();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                membershipsBindingNavigatorSaveItem?.PerformClick();
               // MessageBox.Show(this, "Данные сохранены успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка сохранения!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                bindingNavigatorAddNewItem?.PerformClick();
                int newUID = int.Parse(bindingNavigatorPositionItem.Text);
                membershipIDComboBox.Text = newUID.ToString();

            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка добавления!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        membershipsBindingNavigatorSaveItem?.PerformClick();
                       // MessageBox.Show(this, "Сохранение успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка удаления!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSortWithForeign_Click(object sender, EventArgs e)
        {
            //select MembershipID,MembershipTypes.Name,MembershipTypes.Description,MembershipTypes.Price,MembershipTypes.DurationMonths,Memberships.StartDate,Memberships.EndDate,Clients.FirstName,Clients.LastName,Clients.Phone,Clients.Email,Clients.BirthDate from Memberships JOIN Clients ON (Memberships.ClientID = Clients.ClientID) JOIN MembershipTypes ON (Memberships.MembershipTypeID = MembershipTypes.MembershipTypeID)
            var JOIN_ON = Program.SERVER_SQL.CreateCommand();
            JOIN_ON.CommandText = "select MembershipID,MembershipTypes.Name,MembershipTypes.Description,MembershipTypes.Price,MembershipTypes.DurationMonths,Memberships.StartDate,Memberships.EndDate,Clients.FirstName,Clients.LastName,Clients.Phone,Clients.Email,Clients.BirthDate from Memberships JOIN Clients ON (Memberships.ClientID = Clients.ClientID) JOIN MembershipTypes ON (Memberships.MembershipTypeID = MembershipTypes.MembershipTypeID)";
            Tables.Table_Common_Handler handler_with_references = new Tables.Table_Common_Handler(JOIN_ON);
            handler_with_references.Show(this);
        }
    }
}
