using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Diagnostics;
using FitnessClub.JSON;
using Newtonsoft.Json;
using System.Security.AccessControl;
using System.Reflection.Emit;
using System.Drawing;
using System.IO;
using System.Threading;


namespace FitnessClub
{

    public static class Debugger
    {
        /// <summary>
        /// Дебаггер для удобства записи и вывода ошибок (немного поглащения)
        /// </summary>
        /// <param name="i"></param>
        /// <param name="level"></param>
        /// <param name="message"></param>
        public static void Log(int i,string level,string message)
        {
            try
            {

                //Если уровень стоит на запись в файл (по умолчанию Debug)
                if (level == "Debug/File")
                {
                    System.IO.File.AppendAllText("DebugFile.log", $"{Environment.NewLine}{System.DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()} -> {i} {level}{Environment.NewLine}{message}");
                }
                //Определяем уровень если ошибка вывод в консоли КРАСНЫМ, если предупреждение ЖЁЛТЫМ в ином случае белый
                if (message.ToUpper().Contains("WARNING") || message.ToUpper().Contains("ПРЕДУПРЕЖДЕНИЕ"))
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (message.ToUpper().Contains("ERROR") || message.ToUpper().Contains("ОШИБКА"))
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"i: {i}\nLevel: {level}\nMessage:\n{message}");
                System.Diagnostics.Debugger.Log(i, level.Split('/')[0], message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch(Exception g)
            {
                //Обрабатываем исключение т.к. одновременный вызов функции на уровне записи может привести к ошибки доступа
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tMultiThread Debugger ERROR");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
    /// <summary>
    /// Роли
    /// </summary>
    public enum Role
    {
        User = 0,
        Admin = 1
    }

    public static class Program
    {
        //P.S> ДА я знаю что Program уже божественный класс
        /// <summary>
        /// Относительно истины/лож вернём роль как перечисление
        /// </summary>
        /// <param name="r">Роль: Истина/Лож</param>
        /// <returns></returns>
        public static Role GetRole(bool r)
        {
            if (r)
                return Role.Admin;
            else
                return Role.User;
        }
        /// <summary>
        /// Перегрузка прошлого метода (только наоборот)
        /// </summary>
        /// <param name="role">Перечисление</param>
        /// <returns></returns>
        public static bool GetRole(Role role)
        {
            if (role == Role.Admin)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Конвертор изображение в base64 строку
        /// </summary>
        /// <param name="image">Изображение</param>
        /// <returns>Строка base64</returns>
        public static string BitmapToBase64(Bitmap image)
        {
            using (var ms = new MemoryStream())
            {
                using (var bitmap = new Bitmap(image))
                {
                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var SigBase64 = Convert.ToBase64String(ms.GetBuffer()); //Get Base64
                    return SigBase64;
                }
            }
        }
        /// <summary>
        /// Конвертор строки base64 в изображение
        /// </summary>
        /// <param name="base64String">Строка base64</param>
        /// <returns>Bitmap изображение</returns>
        public static Bitmap Base64ToBitmap(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return (Bitmap)image;
        }

        /// <summary>
        /// МЕТОД ДЛЯ ЗАПИСИ В БАЗУ
        /// </summary>
        /// <param name="sql">Запрос</param>
        /// <returns>Код результата</returns>
        public static int Insert(string sql)
        {
            try
            {
                //Блокаем выполнение исходного потока ради подпотока (решает баг когда у нас одновременно обновляются изрб. на форме и в базе)
                Program.ThreadLoadImage.Join();

                var command = SERVER_SQL.CreateCommand();
                command.CommandText = sql;
                Debugger.Log(0, "Debug", $"\n\tINSERT: {sql}\n");
                int res = command.ExecuteNonQuery();
                
                Debugger.Log(0, "Debug", $"\n\t\t=======> {res}\n");
                return res;
            }
            catch(Exception g)
            {
                Debugger.Log(0, "Debug/File", g.ToString());
            }
            return 0;
        }

        /// <summary>
        /// МЕТОД ДЛЯ ЗАГРУЗКИ ИЗ БАЗЫ
        /// </summary>
        /// <param name="sql">Запрос</param>
        /// <returns>DataTable без манипуляций</returns>
        public static DataTable Select(string sql,bool ignoreDebug = false)
        {
            DataTable table = new DataTable();
            try
            {
                // Незаметная рекурсия т.к. этот метод выполняется в самом подпотоке то подпоток начинает ждать самого себя
               // Program.ThreadLoadImage.Join();
                var com = SERVER_SQL.CreateCommand();
                com.CommandText = sql;
                if (!ignoreDebug)
                    Debugger.Log(0, "Debug", $"\n\tSELECT: {sql}\n");
                var ireader = com.ExecuteReader();
                table.Load(ireader);
                if (!ignoreDebug)
                    Debugger.Log(0, "Debug", $"\n\t\t=======> {table.Rows.Count}\n");
                var tmp_sereliz = JsonConvert.SerializeObject(table, Formatting.Indented);
                if (!ignoreDebug)
                    Debugger.Log(0, "Debug", $"{tmp_sereliz.ToString()}");
                ireader.Close();
                return table;
            }
            catch(Exception g)
            {
                Debugger.Log(0, "Debug/File", JsonConvert.SerializeObject(g,Formatting.Indented));
                MessageBox.Show(g.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Если отработал catch(Exception) возращаем пустую таблицу (формы будут думать что данные отсутствуют)
            return table;
        }

        /// <summary>
        /// Метод для получения максимального ID из таблицы
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static int GetMaxID(string table,string namerow)
        {
            int id = -1;

            table = table.Trim('[', ']');
            namerow = namerow.Trim('[', ']');

            var data = Select($"SELECT TOP(1) {namerow} FROM [{table}] ORDER BY [{namerow}] DESC");
            if (data.Rows.Count <= 0 || data.Rows.Count > 1)
            {
                return 0;
            }
            else
                id = int.Parse(data.Rows[0].ItemArray[0].ToString());
            return id;
        }
        /// <summary>
        /// Метод для получения и последующего преобразования данных из запроса в динамический тип JArray
        /// </summary>
        /// <param name="sql">Select - запрос</param>
        /// <returns>dynamic объект представления JArray из DataTable</returns>
        public static dynamic Select_Dynamic(string sql)
        {
            var data = Select(sql);
            var tmp_sereliz = JsonConvert.SerializeObject(data, Formatting.Indented);
            var tmp_dereliz = JsonConvert.DeserializeObject(tmp_sereliz);
            dynamic dyn_obj = tmp_dereliz;
            return dyn_obj;
        }
        /// <summary>
        /// Метод подпотока для загрузки изображения
        /// </summary>
        static internal void UpdateImage()
        {
            while (SERVER_SQL.State != ConnectionState.Open)
            {
                Debugger.Log(0, "Debug", "ThreadLoadImage wait 1000ms for connect server!");
                Thread.Sleep(1000);
            }

            var command = Program.Select("SELECT * FROM [Images]",true);
            Images.Clear();
            foreach (DataRow row in command.Rows)
            {
                
                Images.Add(int.Parse(row.ItemArray[0].ToString()), Program.Base64ToBitmap(row.ItemArray[1].ToString()));
                Debugger.Log(0, "Debug/File", "Image was load: " + row.ItemArray[0].ToString() + " | SIZE: " + row.ItemArray[1].ToString().Length + " .");
            }
        }

        /// <summary>
        /// Экземпляр подключения для доп. обращений (берём строку подключения из ресурсов, чтобы не было конфликтов при переносе БД и ПО)
        /// </summary>
        static internal SqlConnection SERVER_SQL = new SqlConnection(Properties.Settings.Default.FitnessClubConnectionString);
        /// <summary>
        /// Словарик для изображений
        /// </summary>
        static internal Dictionary<int, Bitmap> Images = new Dictionary<int, Bitmap>();
        /// <summary>
        /// Подпоток для обновления изображений базы
        /// </summary>
        static internal Thread ThreadLoadImage;
        /// <summary>
        /// Объект серелиза для перевода
        /// </summary>
        public static Rootobject_Translater Translater;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Устанавливаем специальный вывод исключений (Чтобы ловить исключений привязки от MS)
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
            //Подпоток для реализации и проверки подключения к БД
            System.Threading.Thread taskConnect = new System.Threading.Thread(() =>
            {
                try
                {
                    SERVER_SQL.Open();
                }
                catch (Exception g)
                {
                    MessageBox.Show("Критическая ошибка подключение к серверу!\n" + g.Message, "Ошибка сервера!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            })
            {
                IsBackground = true
            };
            taskConnect.Start();
            //Подпоток для фоновой загрузки избр. из быза
            ThreadLoadImage = new Thread(UpdateImage)
            {
                IsBackground = true
            };
            ThreadLoadImage.Start();
            try
            {
                //Проверка существования файла переводчика
                if (System.IO.File.Exists($"{Application.StartupPath}\\rus.json"))
                {
                    //Десериализация java script object notation (JSON)
                    Translater = JsonConvert.DeserializeObject<JSON.Rootobject_Translater>(System.IO.File.ReadAllText($"{Application.StartupPath}\\rus.json", System.Text.Encoding.UTF8));
                    //Проверка списка таблиц
                    if (Translater == null || Translater.Rus == null || Translater.Rus.Count <= 0)
                        Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };

                    foreach(var ele in Translater.Rus)
                    {
                        //Тут мы определяем чего не хватает в сереализаторе
                        if(ele == null)
                        {
                            Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
                            throw new Exception("Ошибка синтаксиса перевода!\nГлавный элемент не найден!");
                        }
                        if(ele.NameTable == null)
                        {
                            Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
                            throw new Exception("Ошибка синтаксиса перевода!\nНазвание таблицы перевода не найдено!");
                        }
                        if(ele.HeaderTable == null)
                        {
                            Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
                            throw new Exception("Ошибка синтаксиса перевода!\nПеревод элемента не найден!");
                        }
                        foreach(var proper in ele.Property)
                        {
                            if(proper == null)
                            {
                                Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
                                throw new Exception("Ошибка синтаксиса перевода!\nГлавный элемент свойства не найден! (Proper)");
                            }
                            if(proper.HeaderProperty == null)
                            {
                                Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
                                throw new Exception("Ошибка синтаксиса перевода!\nПеревод элемента таблицы не найден! (HeaderProperty)");
                            }
                            if(proper.NameProperty == null)
                            {
                                Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
                                throw new Exception("Ошибка синтаксиса перевода!\nПеревод элемента свойства не найден! (NameProperty)");
                            }
                        }
                    }

                }
                else
                    Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
            }
            catch (Exception g)
            {
                MessageBox.Show("Program.cs [Translater initializator]\n" + g.Message, "PROGRAMM ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("В инициализаторе перевода возникла ошибка!\nДальнейшей перевод не возможен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //При полном отсутствие или неполноценности данных инициализуем пустой экземпляр (в ином случае будет NullRefrences везде где используется этот экземпляр, по другому говоря это заглушка)
                Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
            }
            Properties.Settings.Default.Role = GetRole(Role.User);
            Properties.Settings.Default.Save();
            //Базовый код WinForms для запуска
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        

    }
}
