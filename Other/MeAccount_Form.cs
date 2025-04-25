using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub.Other
{
    public partial class MeAccount_Form : Form
    {
        public MeAccount_Form()
        {
            InitializeComponent();
        }
        dynamic iam;
        bool longorshort = false;
        private void MeAccount_Form_Load(object sender, EventArgs e)
        {
            btnRetry.Image = btnRetry.ErrorImage;

            MenuItem it_change_photo = new MenuItem()
            {
                Text = "Изменить изображение"
            };
            it_change_photo.Click += (_sen, _e) =>
            {
                //HERE WE NEED LOGIC FOR CHANGE IMAGE ON SERVER
                int identity = Properties.Settings.Default.ID;

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
                        if (data.Rows.Count > 0)
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

                            string sql_update = $"Update [Clients] SET [ImageID] = {newID} WHERE ClientID = \'{identity}\'";
                            var result_update = Program.Insert(sql_update);
                            if(result_update == 1)
                            {
                                MessageBox.Show(this, "Изображение успешно загружено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MeAccount_Form_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show(this, "Неизвестная ошибка!\nКод возврата: " + result_update.ToString(), "Не удалось загрузить!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            int identifity_last_image = int.Parse(data.Rows[0].ItemArray[0].ToString());
                            //HERE WE NEED UPDATE TABLE FOR ID IMAGE IF HE WAS HATE
                            string sql_update = $"Update [Clients] SET [ImageID] = {identifity_last_image} WHERE ClientID = \'{identity}\'";
                            var result_update = Program.Insert(sql_update);
                            if(result_update == 1)
                            {
                                MessageBox.Show(this, "Изображение успешно установлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MeAccount_Form_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show(this, "Неизвестная ошибка!\nКод возврата: " + result_update.ToString() + "\nПримечание: Set Loop", "Не удалось загрузить!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception g)
                    {
                        MessageBox.Show(g.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };

            pictureBox1.ContextMenu = new ContextMenu();
            pictureBox1.ContextMenu.MenuItems.Add(it_change_photo);


            try
            {
                int identity = Properties.Settings.Default.ID;
                var clients = Program.Select_Dynamic($"SELECT * FROM Clients WHERE ClientID = {identity}");
                iam = clients[0];
                if (iam["ImageID"] != null)
                {
                    pictureBox1.Image = Program.Images[int.Parse(iam["ImageID"].ToString())];
                }

                txtName.Text = iam["FirstName"].ToString();
                txtSurname.Text = iam["LastName"].ToString();

                txtBirth.Text = DateTime.Parse(iam["BirthDate"].ToString()).ToLongDateString();
                txtNumbers.Text = iam["Phone"].ToString();
                txtEmail.Text = iam["Email"].ToString();
                txtAddress.Text = iam["Address"].ToString();
            }
            catch(Exception g)
            {
                Debugger.Log(0, "Debug/File", g + "");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            if(longorshort)
            {
                txtBirth.Text = DateTime.Parse(iam["BirthDate"].ToString()).ToLongDateString();
            }
            else
            {
                txtBirth.Text = DateTime.Parse(iam["BirthDate"].ToString()).ToShortDateString();
            }
            longorshort = !longorshort;
        }

        private void btnSavePersonData_Click(object sender, EventArgs e)
        {
            //TODO: Написать алгоритм загрузки/обновления фотографии профиля для клиента
            /*
ClientID                                                                                                                
FirstName                                                                                                               
LastName                                                                                                                
BirthDate                                                                                                               
Phone                                                                                                                   
Email                                                                                                                   
Address                                                                                                                 
ImageID 
             
             */
            int identity = Properties.Settings.Default.ID;

            DateTime newDate = new DateTime();
            if (DateTime.TryParse(txtBirth.Text, out newDate))
            {
                int result = Program.Insert($"UPDATE Clients SET FirstName = \'{txtName.Text}\', LastName = \'{txtSurname.Text}\', BirthDate = \'{newDate.ToShortDateString()}\', Phone = \'{txtNumbers.Text}\', Email = \'{txtEmail.Text}\',Address = \'{txtAddress.Text}\' WHERE ClientID = {identity}");
                if (result == 1)
                {
                    MessageBox.Show(this, "Данные успешно обновлены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MeAccount_Form_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(this, "Неизвестная ошибка обновления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if(MessageBox.Show(this, "Не удалось распознать дату!\nПродолжить сохранение?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = Program.Insert($"UPDATE Clients SET FirstName = \'{txtName.Text}\', LastName = \'{txtSurname.Text}\', Phone = \'{txtNumbers.Text}\', Email = \'{txtEmail.Text}\',Address = \'{txtAddress.Text}\' WHERE ClientID = {identity}");
                    if (result == 1)
                    {
                        MessageBox.Show(this, "Данные успешно обновлены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MeAccount_Form_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(this, "Неизвестная ошибка обновления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Действие обновления данных остановлено!", "Остановление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnRefocusContextMenu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ContextMenu != null)
                pictureBox1.ContextMenu.Show(this, new Point(btnRefocusContextMenu.Width / 2, btnRefocusContextMenu.Height / 2));
        }
    }
}
