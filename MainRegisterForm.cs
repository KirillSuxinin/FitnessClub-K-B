using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub
{
    public partial class MainRegisterForm : Form
    {
        public MainRegisterForm(int id,string name,string description,int price,string duration)
        {
            InitializeComponent();
            dynamic_style.Enable(this);
            this.lab_reg_on.Text = $"Регистрация на \'{name}\'";
            this.INDEX = id;
            this.NameA = name;
            this.DescriptionA = description;
            this.PriceA = price;
            this.DurationA = duration;
        }
        private int INDEX;
        private string NameA;
        private string DescriptionA;

        private int PriceA;
        private string DurationA;


        private void btnPay_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://online.sberbank.ru/");
        }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static Random rand = new Random();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Control[] validation_control = new Control[]
            {
                txt_name,
                txt_surname,
                txt_date,
                txtNumber,
                txtAddress,
                txtEmail,
            };
            bool validationOnNull = true;
            DateTime dateBirth = new DateTime();
            if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_surname.Text) || !DateTime.TryParse(txt_date.Text, out dateBirth) || string.IsNullOrWhiteSpace(txtNumber.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
                validationOnNull = false;
            if (!IsValid(txtEmail.Text))
                validationOnNull = false;

            if (validationOnNull)
            {
                int code = rand.Next(1111, 9999);
                Thread th = new Thread(() =>
                {
                    try
                    {
                        string from = "techicalsuhinin@yandex.ru";
                        string pass = "gezmmycdvpihuuay";//Раньше тут был настоящий пароль от аккаунта
                        SmtpClient client = new SmtpClient();
                        client.Host = "smtp.yandex.ru";
                        //Порт - незащищённый
                        client.Port = 587;
                        //Но при этом используем SSL защиту
                        client.EnableSsl = true;
                        client.Credentials = new System.Net.NetworkCredential(from, pass);
                        Debugger.Log(0, "Debug", $"\n\tНачало отправки: {code}\n");
                        client.Send(from, txtEmail.Text, "Регистрация в FitnessClub", $"Здравствуйте {txt_name.Text} {txt_surname.Text}{Environment.NewLine}Вы оставили заявку на покупку абонемента в нашем фитнес клубе.{Environment.NewLine}Время: \"{System.DateTime.Now.ToShortDateString()} {System.DateTime.Now.ToShortTimeString()}\"\nОб абонемента:{Environment.NewLine}Наименование: {NameA}{Environment.NewLine}Описание: {DescriptionA}{Environment.NewLine}Стоимость: {PriceA} руб. {Environment.NewLine}Период: {DurationA} месяцев. {Environment.NewLine}{Environment.NewLine}Ваш код подтверждения заявки: \"{code}\"{Environment.NewLine}Не закрывайте приложение, в ином случае придется заполнять данные заново.");
                        Debugger.Log(0, "Debug", $"\n\tОкончание отправки!\n");
                    }
                    catch(Exception g)
                    {
                        MessageBox.Show(this, g.Message, "Ошибка сети SMTP протокол", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                });
                th.Start();

                GetRegisterCodeForm codeform = new GetRegisterCodeForm(txtEmail.Text);
                var result = codeform.ShowDialog(this);
                if (result == DialogResult.OK && codeform.GetCode == code)
                {
                    //ПОСЛЕ ТОГО КАК ПОЛЬЗОВАТЕЛЬ ВВЕЛ СВОИ ДАННЫЕ И ПОСЛЕ ВВОДКА КОДА С ПОЧТЫ
                    //ДЕЛАЕМ ЗАПИСЬ НА СОЗДАНИЯ КЛИЕНТА (КОТОРЫЙ В БУДУЩЕМ АДМИН БУДЕТ РЕШАТЬ ОДОБРИТЬИЛИ НЕТ)
                    var command = Program.SERVER_SQL.CreateCommand();

                    int id_new_member = -1;
                    var tmp_command = Program.SERVER_SQL.CreateCommand();
                    tmp_command.CommandText = "SELECT TOP(1) [ClientID] FROM [Clients] ORDER BY [ClientID] DESC";
                    var tmp_reader = tmp_command.ExecuteReader();
                    DataTable tmp_table = new DataTable();
                    tmp_table.Load(tmp_reader);
                    tmp_reader.Close();
                    if (int.TryParse(tmp_table.Rows[0].ItemArray[0].ToString(), out id_new_member))
                    {
                        //ЗАПИСЬ В ТАБЛИЦУ КЛИЕНТЫ
                        id_new_member++;
                        command.CommandText = $"INSERT INTO [Clients] VALUES({id_new_member},\'{txt_name.Text}\',\'{txt_surname.Text}\',\'{txt_date.Text}\',\'{txtNumber.Text}\',\'{txtEmail.Text}\',\'{txtAddress.Text}\',NULL)";
                        command.ExecuteNonQuery();
                        //ЗАПИСЬ В ТАБЛИЦУ Memberships (КОД INDEX - ИД ДЛЯ АБОНЕМЕНТА, КОД ПЗ)
                        //STARTDATE - Высчитывается от момента заявки до +МЕСЯЦ АБОНЕМЕНТА
                        int id_new_memberships = Program.GetMaxID("Memberships","MembershipID")+1;
                        string startDate = System.DateTime.Now.ToShortDateString();
                        string endDate = (System.DateTime.Now.AddMonths(int.Parse(DurationA))).ToShortDateString();
                        Program.Insert($"INSERT INTO [Memberships] VALUES({id_new_memberships},{id_new_member},{INDEX},\'{startDate}\',\'{endDate}\')");



                        //ДОБАВЛЕНИЕ КОДА ЗАПИСИ Memberships в ТАБЛИЦУ Payments ДЛЯ ПОНИМАНИЯ ОБ ОПЛАТЕ

                        int id_new_payment = Program.GetMaxID("[Payments]", "[PaymentID]") + 1;
                        Program.Insert($"INSERT INTO [Payments] VALUES({id_new_member},{id_new_memberships},\'{System.DateTime.Now.ToShortDateString()}\',{PriceA},\'Онлайн\')");


                        //ОТКАЗ ОТ ЛОГИКИ ОДОБРЕНИЯ РЕГИСТРАЦИИ ПОЛЬЗОВАТЕЛЯ
                        //ДОП.ФОРМА: ОКОНЧАТЕЛЬНАЯ РЕГИСТРАЦИИ ИНФ.АККАУНТА В ТАБЛИЦЕ USERS
                        string passN = System.Web.Security.Membership.GeneratePassword(12, 0);
                        int id_new_users = Program.GetMaxID("Users", "ID")+1;
                        Program.Insert($"INSERT INTO [Users] VALUES({id_new_users},{id_new_member},\'{txtEmail.Text.Split('@')[0]}\',\'{passN}\',\'User\')");
                        try
                        {
                            string from = "techicalsuhinin@yandex.ru";
                            string pass = "gezmmycdvpihuuay";
                            SmtpClient client = new SmtpClient();
                            client.Host = "smtp.yandex.ru";
                            client.Port = 587;
                            client.EnableSsl = true;
                            client.Credentials = new System.Net.NetworkCredential(from, pass);
                            Debugger.Log(0, "Debug", $"\n\tНачало отправки: {passN}\n");
                            client.Send(from, txtEmail.Text, "Регистрация в FitnessClub", $"Здравствуйте {txt_name.Text} {txt_surname.Text}{Environment.NewLine}{Environment.NewLine}Логин: {txtEmail.Text}{Environment.NewLine}Пароль: {passN}{Environment.NewLine}Никому не сообщайте ваши данные!");
                            Debugger.Log(0, "Debug", $"\n\tОкончание отправки!\n");


                            MessageBox.Show(this, "Вы успешно зарегистрировались!\nЛогин и пароль для входа отправлен вам на почту!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.Retry;
                            this.Close();
                        }
                        catch(Exception g)
                        {
                            MessageBox.Show(this, g.Message, "Ошибка сети SMTP протокол", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show(this, "Не удалось зарегистрировать пользователя с такими ключём!.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(result == DialogResult.OK && codeform.GetCode != code)
                {
                    if(MessageBox.Show(this,"Введен не правильный код!\nПовторить попытку?","Ошибка",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        btnRegister.PerformClick();
                    }
                }
                else if(result == DialogResult.Abort)
                {
                    //ЕСЛИ КОД НЕ ПРИШЁЛ ДЕЛАЕМ ЛОКАЛЬНЫЙ КОД
                    MessageBox.Show("Ошибка авторизации","Не удалось",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }




            }
            else
            {
                MessageBox.Show(this, "Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnGO_IN_A_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
    }
}
