using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub
{
    public partial class AuthMainForm : Form
    {
        public AuthMainForm()
        {
            InitializeComponent();
            dynamic_style.Enable(this);
            if (Properties.Settings.Default.SaveAuth)
            {
                ckc_save.Checked = true;
                if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.Login) || !string.IsNullOrWhiteSpace(Properties.Settings.Default.Password))
                {
                    txtLogin.Text = Properties.Settings.Default.Login;
                    txtPass.Text = Properties.Settings.Default.Password;
                }
            }
        }

        private void chc_pass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !chc_pass.Checked;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ckc_save_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveAuth = ckc_save.Checked;
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Login = txtLogin.Text;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Password = txtPass.Text;
        }

        private void AuthMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLogin.Text) && !string.IsNullOrWhiteSpace(txtPass.Text))
            {
                var command = Program.SERVER_SQL.CreateCommand();
                command.CommandText = $"SELECT * FROM [Users] WHERE [Login] = \'{txtLogin.Text}\' and [Password] = \'{txtPass.Text}\'";
                var reader = command.ExecuteReader();
                DataTable tmp_table = new DataTable();
                tmp_table.Load(reader);
                reader.Close();
                //Проверка если нету элементов аккаунтов или аккаунтов больше чем нужно
                if (tmp_table.Rows.Count <= 0 || tmp_table.Rows.Count > 1)
                {
                    MessageBox.Show(this, "Введен неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string roly = tmp_table.Rows[0].ItemArray[4].ToString();
                    if (roly.ToUpper() == "ADMIN")
                        Properties.Settings.Default.Role = Program.GetRole(Role.Admin);

                    else
                        Properties.Settings.Default.Role = Program.GetRole(Role.User);

                    string ids = tmp_table.Rows[0].ItemArray[1].ToString();

                    int id = -1;
                    if (int.TryParse(ids, out id))
                    {
                        Properties.Settings.Default.ID = id;
                        //Сохраняем выше указанные параметры только в том случае если авторизация успешна и пользователь существует
                        Properties.Settings.Default.Save();

                        MainHandlerForm handler = new MainHandlerForm();
                        this.Hide();
                        handler.ShowDialog(this);
                        this.Show();

                    }
                    else if(Properties.Settings.Default.Role == Program.GetRole(Role.User))
                    {
                        MessageBox.Show(this, "Не удалось идентифицировать пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(Properties.Settings.Default.Role == Program.GetRole(Role.Admin))
                    {
                        Properties.Settings.Default.ID = -1;
                        Properties.Settings.Default.Save();

                        MainHandlerForm handler = new MainHandlerForm();
                        this.Hide();
                        handler.ShowDialog(this);
                        this.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Не все поля заполнены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAuth.PerformClick();
            }
        }
    }
}
