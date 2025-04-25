using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//////////////////////////
//      П-46            //
//  Автор: Сухинин К.Д. //
//      10.2024         //
//P.S> Использую        //
//обобщённый            //
//подход к данным       //
//////////////////////////
namespace FitnessClub.Tables
{
    public partial class Table_Common_Handler : Form
    {
        public Table_Common_Handler(string NameTable)
        {
            InitializeComponent();
            dynamic_style.Enable(this);
            this.NameTable = NameTable;
        }

        public void REFRESH_TEST(string newTable)
        {
            this.NameTable = newTable;
            RefreshTable();
        }

        public Table_Common_Handler(IDbCommand table)
        {
            InitializeComponent();
            dynamic_style.Enable(this);
            this.NameTable = null;
            this._TABLE = table;
        }


        /// <summary>
        /// Поле для хранения названия таблицы (тех.название)
        /// </summary>
        private string NameTable;

        private IDbCommand _TABLE;
        /// <summary>
        /// Загружаем и отображаем актуальные данные таблицы
        /// </summary>
        private void RefreshTable()
        {
            var translater = Program.Translater.Rus.Where(x => x.NameTable == NameTable);
            JSON.Tables translater_prop = null;
            if (NameTable != null)
            {
                string title = NameTable;
                if (translater != null)
                {
                    if (translater.Count() > 0)
                    {
                        title = translater.FirstOrDefault().HeaderTable;
                        translater_prop = translater.FirstOrDefault();
                    }
                }
                this.Text = "Сортировка \'" + title + "\'";
            }
            else
            {
                //  this.Text = $"Сортировка \'НЕ ОПРЕДЕЛЕННО\'";
            }


            var dbo_tableView = Program.SERVER_SQL.CreateCommand();
            if (NameTable != null)
                dbo_tableView.CommandText = $"SELECT * FROM [{NameTable}]";
            else
                dbo_tableView = (SqlCommand)_TABLE;

            var reader = dbo_tableView.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            list_columns.Items.Clear();
            cb_collumns.Items.Clear();
            foreach (DataColumn co in table.Columns)
            {
                string co_columnName = co.ColumnName;
                if (translater_prop != null && translater_prop.Property.Where(x => x.NameProperty == co.ColumnName).Count() > 0)
                {
                    co_columnName = translater_prop.Property.Where(x => x.NameProperty == co.ColumnName).FirstOrDefault().HeaderProperty;
                }
                else if (translater_prop == null)
                {

                    foreach (var v in Program.Translater.Rus)
                    {
                        var vs = v.Property.Where(x => x.NameProperty == co_columnName);
                        if (vs != null && vs.Count() > 0)
                            co_columnName = vs.FirstOrDefault().HeaderProperty;
                    }

                }
                list_columns.Items.Add(co_columnName);

                cb_collumns.Items.Add(co_columnName);
            }

            dataGridView1.DataSource = table;
            foreach (DataGridViewColumn cl in dataGridView1.Columns)
            {
                if (translater_prop != null && translater_prop.Property.Where(x => x.NameProperty == cl.Name).Count() > 0)
                    cl.HeaderText = translater_prop.Property.Where(x => x.NameProperty == cl.Name).FirstOrDefault().HeaderProperty;
                else if (translater_prop == null)
                {
                    foreach (var v in Program.Translater.Rus)
                    {
                        var vs = v.Property.Where(x => x.NameProperty == cl.Name);
                        if (vs != null && vs.Count() > 0)
                            cl.HeaderText = vs.FirstOrDefault().HeaderProperty;
                    }
                }

            }
            reader.Close();

            dynamic_style.Enable(this);
        }

        private void Table_Common_Handler_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Проверка на выбор колонки
            if (cb_collumns.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Выберите колонку из выпадающего списка.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Выход из функции если не был выбран индекс в вышестоящем элементе (В ином случае: System.ArgumentOutOfRangeException обеспечен!)
                return;
            }

            //Убираем выбранную ячейку пользователя (В ином случае мы не сможем её скрыть если он не содержит нужные данные поиска)
            dataGridView1.CurrentCell = null;
            //Скрываем все данные
            foreach (DataGridViewRow vc in dataGridView1.Rows)
            {
                vc.Visible = false;
            }
            //Определяем значение поиска (Возможно использование только Text или Items[INDEX]
            string teFind = "NONE";
            if (cbFind.SelectedIndex != -1)
            {
                teFind = cbFind.Items[cbFind.SelectedIndex].ToString();
            }
            else
                teFind = cbFind.Text;
            //Удаляем указательные данные для пользователя на кол.во совпадений
            if (teFind.Contains("→"))
                teFind = teFind.Split('→')[0];


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //Проверяем содержит ли указаная ячейка нужные данные
                if (dataGridView1.Rows[i].Cells[cb_collumns.SelectedIndex].Value.ToString().Contains(teFind))
                {
                    //Отображаем всё строку
                    dataGridView1.Rows[i].Visible = true;
                    //Подсвечиваем (нужно если большое кол.во совпадений)
                  //  dataGridView1.Rows[i].Cells[cb_collumns.SelectedIndex].Style.BackColor = Color.GreenYellow;
                }
            }
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnSorted_Click(object sender, EventArgs e)
        {
            //Тернарный оператор для перечисления на основе Радио кнопок
            ListSortDirection sortAlgorithm = radioButton1.Checked ? ListSortDirection.Ascending : ListSortDirection.Descending;
            if (list_columns.SelectedIndex != -1)
            {
                //Примитивная сортировка
                var column = dataGridView1.Columns[list_columns.SelectedIndex];
                dataGridView1.Sort(column, sortAlgorithm);
                dynamic_style.Enable(this);
            }
        }

        private void cb_collumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_collumns.SelectedIndex == -1)
                return;

            cbFind.Items.Clear();
            //Лист на проверку данных (Чтобы одни и те же данные не добавлялись)
            List<string> checkList = new List<string>();
            //Лист для подсчёта повторяющихся данных
            Dictionary<string, int> checkerFunc = new Dictionary<string, int>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //Проверка на чек-листе
                if (checkList.Where(x => x == dataGridView1.Rows[i].Cells[cb_collumns.SelectedIndex].Value.ToString()).Count() > 0)
                {
                    //Ветления для ведение подсчёта кол.во повторяющихся данных имеет один и тот же вид данных. (И Соответственно примитивная логика проверки для Dictionary<T>)
                    //Если таймер/счётчик для вида данных существует то увеличиваем его
                    //В ином случае мы добавляем этот вид данных и инициализуем ему счётчик с числом 2 т.к. первое вхождение уже было зафиксировано при первичном добавлении данных в рабочий элемент
                    if (checkerFunc.Where(x => x.Key == dataGridView1.Rows[i].Cells[cb_collumns.SelectedIndex].Value.ToString()).Count() > 0)
                        checkerFunc[dataGridView1.Rows[i].Cells[cb_collumns.SelectedIndex].Value.ToString()]++;
                    else
                        checkerFunc.Add(dataGridView1.Rows[i].Cells[cb_collumns.SelectedIndex].Value.ToString(), 2);
                    //Пропускаем добавление одних и тех же данных
                    continue;
                }
                checkList.Add(dataGridView1.Rows[i].Cells[cb_collumns.SelectedIndex].Value.ToString());
                cbFind.Items.Add(dataGridView1.Rows[i].Cells[cb_collumns.SelectedIndex].Value);
            }
            //Добавление итогов кол.во повторений имеет один вид данных
            for (int i = 0; i < cbFind.Items.Count; i++)
            {
                //Добавляем счётчики к контрольному элементу
                if (checkerFunc.Where(x => x.Key == cbFind.Items[i].ToString()).Count() > 0)
                {
                    if (checkerFunc[cbFind.Items[i].ToString()] > 0)
                        cbFind.Items[i] = $"{cbFind.Items[i]}→{checkerFunc.Where(x => x.Key == cbFind.Items[i].ToString()).FirstOrDefault().Value}";
                }
            }
            //Сортируем отображения текстовых подсказок в один порядок
            //В ИНОМ СЛУЧАЕ: При внешней сортировки (пользователем) данные отображаются в зависимости от сортировки
            //ИЗМ: Пхаха переводим в список объектов, потом в лист, лист итерационно в строку и IEnumerable<string> переводим обратно в List<Object> в ином случае сортировка типов decimal,int,double,float,DateTime и д.р. невозможна!
            var copyObj = cbFind.Items.Cast<object>().ToList().Select(x => x.ToString()).ToList<object>();
            //Удаляем старые несортированные данные
            cbFind.Items.Clear();
            //Сортируем список
            copyObj.Sort();
            //Добавляем на контрольный элемент
            cbFind.Items.AddRange(copyObj.ToArray());
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //P.S> Как по мне лучше использовать средства Excel чем обращатся к устаревшим интерфейсам печати
            //Алгоритм сохранение данных в CSV таблицу для дальнейшей печати
            //Диалоговое окно создания/выборки файла для сохранения
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Сохранить .csv файл";
            //Установка ограничение на создание ТОЛЬКО .CSV ФАЙЛОВ
            //Выбрал .CSV файла т.к. они легко интепретируются (создаются/изменяются) в любом формате
            //И после создания таково файла возможна печать с помощью средств Office
            save.Filter = "*.csv|*.csv";
            if (save.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    //Строки для создания в .CSV
                    var lines = new List<string>();
                    //Выборка столбцов (для реализации изменения)
                    List<string> columns = dataGridView1.Columns.Cast<DataGridViewColumn>().Select(x => x.Name).ToList();

                    if (MessageBox.Show(this, "Изменить отображение столбцов?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Other.ChangeStructureOutputTableForm handlerColumns = new Other.ChangeStructureOutputTableForm(columns, dataGridView1.Rows[0].Cells.Cast<DataGridViewCell>().Select(x => x.Value.ToString()).ToList());
                        if (handlerColumns.ShowDialog(this) == DialogResult.OK)
                            columns = handlerColumns.Result;
                    }
                    //Наименование столбцов в виде IEnumerable<string>
                    string[] columnNames = dataGridView1.Columns.Cast<DataGridViewColumn>().Where(x => columns.Where(z => z == x.Name).FirstOrDefault() != null).Cast<DataGridViewColumn>().Select(x => x.HeaderText).ToArray();
                    //Подставляем ориг. именование столбцов если нужны тех. значение в заголовках .csv
                    if (MessageBox.Show(this, $"Оставить оригинальные наименование столбцов?\nПример: \'{dataGridView1.Columns[0].HeaderText}\' -> \'{dataGridView1.Columns[0].Name}\'", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        columnNames = dataGridView1.Columns.Cast<DataGridViewColumn>().Where(x => columns.Where(z => z == x.Name).FirstOrDefault() != null).Cast<DataGridViewColumn>().Select(x => x.Name).ToArray();
                    }
                    //Объединяем IEnumerable<string> в string через ';' т.к. это основной формат .csv
                    var header = string.Join(";", columnNames.Select(name => $"\"{name}\""));
                    //Добавляем заголовки/столбцы для прим. отображения
                    lines.Add(header);
                    //IEnumerable<string> который в себя содержит все представленные rows
                    List<string> valueLines = new List<string>();
                    //Алгоритм добавления ROW[N] в итоговую таблицу с учётом форматирование
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        //Только доступные строки
                        if (dataGridView1.Rows[i].Visible)
                        {
                            //IEnumerable<string> который будет содержать обрезанный row относительно тех столбцов которые оставил пользователь на моменте "Изменение структуры столбцов"
                            List<string> add = new List<string>();
                            for (int c = 0; c < dataGridView1.Rows[i].Cells.Count; c++)
                            {
                                //Проверка является ли столбец отображаемым или нет
                                if (columns.Where(x => x == dataGridView1.Columns[c].Name).Count() > 0)
                                {
                                    add.Add(dataGridView1.Rows[i].Cells[c].Value.ToString());
                                }
                                else
                                    continue;
                            }
                            //Если в ROW есть хоть одно значение то добавляем его с форматирование через ';' формата .csv
                            if (add.Count > 0)
                                valueLines.Add(string.Join(";", add));
                        }
                    }
                    //Добавляем IEnumerable<string> представления N экземпляра данных (Всех rows) к HEADER
                    lines.AddRange(valueLines);
                    //Итог: мы получим .csv таблицу которая будет содержать только те столбцы которые оставил пользователь
                    //НЕ БАГ А ФИЧА: т.к. данные берутся напрямую из DataGridView, а не из Источника то в таблице будут данные которые видит пользователь на форме отображения в момент нажатия данной кнопки, со всеми сортировками и со всеми фильтрами (кроме цвета и выделения)
                    //P.S.> Не знаю как менять стили ячейкам в .csv когда сам .csv файл состоит из примитивного текста с разделителями (Стили реализуемы, но факт того что при добавлении html и иных тэгов для стиля может слететь кириллица в данных существует)
                    System.IO.File.WriteAllLines(save.FileName, lines, System.Text.Encoding.UTF8);
                    MessageBox.Show(this, $"Таблица успешна записана в \'{new FileInfo(save.FileName).Name}\' и готова для печати.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception g)
                {
                    MessageBox.Show(this, g.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                //без понятия зачем вообще эта кнопка нужна)
                printDialog1.Document = printDocument1;
                printDialog1.ShowDialog(this);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Bitmap bt = new Bitmap(dataGridView1.Width + 10, dataGridView1.Height + 10);
                dataGridView1.DrawToBitmap(bt, dataGridView1.Bounds);
                e.Graphics.DrawImage(bt, new PointF(0, 0));
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int indexRow = dataGridView1.SelectedCells[0].RowIndex;
                lab_counter.Text = $"{indexRow + 1} для {dataGridView1.Rows.Count}";
            }
            else
            {
                lab_counter.Text = $"-";
            }
        }
    }
}
