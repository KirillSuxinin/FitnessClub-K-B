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
    public partial class Clients_Form : Form
    {
        public Clients_Form()
        {
            InitializeComponent();
            dynamic_style.Enable(this);

        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {


                this.Validate();
                this.clientsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.fitnessClubDataSet);
                MessageBox.Show(this, "Данные сохранены успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception g)
            {
                MessageBox.Show(this, "Не удалось применить сохранения!\n" + g.Message + "\nИзменения будут отменены!", "Критическая ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clientsBindingSource.CancelEdit();
            }
        }

        private void Clients_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Images". При необходимости она может быть перемещена или удалена.
            this.imagesTableAdapter.Fill(this.fitnessClubDataSet.Images);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.fitnessClubDataSet.Clients);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MovePrevious();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clientsBindingSource.CancelEdit();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveNext();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveLast();
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
                        clientsBindingNavigatorSaveItem?.PerformClick();
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
                clientIDComboBox.Text = newUID.ToString();

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
                clientsBindingNavigatorSaveItem?.PerformClick();
               // MessageBox.Show(this, "Данные сохранены успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка сохранения!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            Tables.Table_Common_Handler clients = new Tables.Table_Common_Handler("Clients");
            clients.Show(this);
        }

        private void imageCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            if (!string.IsNullOrWhiteSpace(imageCmb.Text))
            {
                if (Program.Images.Where(x => x.Key.ToString() == imageCmb.Text).Count() > 0)
                    pictureBox1.Image = Program.Images[int.Parse(imageCmb.Text)];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image PNG|*.PNG|Image JPG|*.JPG|All Files|*.*";
            if (open.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    int newID = Program.GetMaxID("Images", "ImageID") + 1;
                    Bitmap bit = new Bitmap(open.FileName);
                    string base64 = Program.BitmapToBase64(bit);
                    bool hasinbase = false;

                    var data = Program.Select($"SELECT ImageID FROM [Images] WHERE ImageBase64 = \'{base64}\'");
                    if(data.Rows.Count > 0)
                    {
                        hasinbase = true;
                    }
                    if (!hasinbase)
                    {
                        Program.Insert($"INSERT INTO [Images] VALUES({newID},\'{base64}\')");
                        Program.ThreadLoadImage = new System.Threading.Thread(Program
                            .UpdateImage)
                        {
                            IsBackground = true
                        };
                        Program.ThreadLoadImage.Start();
                        this.Clients_Form_Load(null, null);
                        MessageBox.Show(this, "Изображение успешно добавлено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(this, $"Данное изображение уже существует в базе.\nИдентификатор: {data.Rows[0].ItemArray[0].ToString()}", "Не удалось добавить", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception g)
                {
                    MessageBox.Show(g.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void clientsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            if (!string.IsNullOrWhiteSpace(imageCmb.Text))
            {
                if (Program.Images.Where(x => x.Key.ToString() == imageCmb.Text).Count() > 0)
                    pictureBox1.Image = Program.Images[int.Parse(imageCmb.Text)];
            }
        }
    }
}
