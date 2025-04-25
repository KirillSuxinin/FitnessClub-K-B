using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//====================
//АВТОР СУХИНИН К.Д. |
//====================
namespace FitnessClub
{
    /// <summary>
    /// Класс для применений цвета проекта и доп. обработка
    /// </summary>
    public static class dynamic_style
    {
        private static Color FromHEX(string hex)
        {
            int argb = Int32.Parse(hex.Replace("#", ""), NumberStyles.HexNumber);
            Color clr = Color.FromArgb(argb);
            return clr;
        }
        /// <summary>
        /// Метод применения цветовой палитры
        /// </summary>
        /// <param name="form">Форма на которой нужен стиль</param>
        public static void Enable(Form form)
        {
            //HERE WE STANDART FORM STYLE FOR DOTHER FORM
            form.KeyUp -= Handler_KeyUp;
            form.KeyUp += Handler_KeyUp;
            if (!form.Text.ToUpper().Contains("Фитнес - Клуб: К & Б".ToUpper()))
            {
                form.Text = $"Фитнес - Клуб: К & Б. {form.Text}";
            }
            //ДАННОЕ СОБЫТИЕ ОБРАБАТЫВАЕТ ФОРМЫ С ТЭГОМ SAVE_SIZE И ОТКРЫВАЕТ ИХ С СОСТОЯНИЕМ ИХ РОДИТЕЛЕЙ. (РАЗВЕРНУТ НА ВЕСЬ ЭКРАН ИЛИ ОБЫЧНЫЙ. СКРЫТЫЙ РЕЖИМ НЕ ОБРАБАТЫВАЕТ)
            form.Load -= LOAD;
            form.Load += LOAD;

            //Рекурсивно добавляем обработчик для горячих клавиш
                foreach (var vsCW_form in form.Controls)
                {
                    try
                    {
                        (vsCW_form as Control).KeyUp -= Handler_KeyUp;
                        (vsCW_form as Control).KeyUp += Handler_KeyUp;
                        if (vsCW_form is GroupBox || vsCW_form is Panel)
                        {
                            Recursive_Enable(vsCW_form as Control);
                        }
                        else
                            InvokeStyle(vsCW_form as Control);
                    }
                    catch (Exception g)
                    {
                        Debugger.Log(0, "Debug", $"\n{g}");
                    }
                }

        }
        /// <summary>
        /// Событие загрузки формы для обработки состояния WindowState относительно родителей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void LOAD(object sender, EventArgs e)
        {

            var @_form = (sender as Form);
            if (@_form.Owner != null && @_form.Tag != null && @_form.Tag.ToString().ToUpper() == "SAVE_SIZE")
            {
                @_form.WindowState = @_form.Owner.WindowState;
            }
        }



        /// <summary>
        /// Событие горячих клавиш
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Handler_KeyUp(object sender, KeyEventArgs e)
        {
            if (((sender as Control).FindForm() is Tables.Table_Common_Handler))
            {
                if (e.KeyCode == Keys.F2)
                {
                    Other.ChangeTable_TEST change = new Other.ChangeTable_TEST();
                    if (change.ShowDialog((sender as Control).FindForm() as IWin32Window) == DialogResult.OK)
                    {
                        ((sender as Control).FindForm() as Tables.Table_Common_Handler).REFRESH_TEST(change.ReturnText);
                    }
                }
            }

            if (e.KeyCode == Keys.F1)
            {
               
            }
            if(e.KeyCode == Keys.F3)
            {
                if (((sender as Control).FindForm() is MainHandlerForm))
                {
                    Lenta.Class_Trainers_Equipment_Form cl = new Lenta.Class_Trainers_Equipment_Form();
                    cl.ShowDialog((sender as Control).FindForm());
                }
            }
            if(e.KeyCode == Keys.F4)
            {
                Environment.Exit(0);
            }
        }
        /// <summary>
        /// Рекурсивный метод добавления горячих клавиш и стилей
        /// </summary>
        /// <param name="vControl"></param>
        private static void Recursive_Enable(Control vControl)
        {

            foreach (var element in vControl.Controls)
            {
                (element as Control).KeyUp -= Handler_KeyUp;
                (element as Control).KeyUp += Handler_KeyUp;
                if (element is GroupBox || element is Panel)
                    Recursive_Enable(element as Control);
                else
                    InvokeStyle(element as Control);
            }
        }
        /// <summary>
        /// Метод обработки элемента
        /// </summary>
        /// <param name="vs">Элемент</param>
        /// <exception cref="Exception">Если элемент не существует или был уничтожен</exception>
        private static void InvokeStyle(Control vs)
        {
            if (vs == null)
                throw new Exception("Ошибка стилей!\nНе найден элемент применения стилей.");
            //Нужно если в будущем будут подпотоки
            if (vs.IsDisposed)
                throw new Exception("Ошибка стилей\nЭлемент был уничтожен");


            //УСТАНОВКА ЛОГИКИ РАБОТЫ ЭЛЕМЕНТОВ ОТНОСИТЕЛЬНО ПРАВ
            if (vs is Button)
            {
                if (vs.AccessibleDescription != null)
                {
                    if (vs.AccessibleDescription.ToString().ToUpper() == "ONLY_ADMIN".ToUpper())
                    {
                        if (Program.GetRole(Properties.Settings.Default.Role) == Role.User)
                        {
                            vs.Visible = false;
                        }
                    }
                    if (vs.AccessibleDescription.ToString().ToUpper() == "ONLY_USER".ToUpper())
                    {
                        if (Program.GetRole(Properties.Settings.Default.Role) == Role.Admin)
                        {
                            vs.Enabled = false;
                        }
                    }
                }
            }


            //Тэг обработки для исключения элемента из обработки
            if (vs.AccessibleName != null)
                if (vs.AccessibleName == "NONESTYLE")
                    return;

            if(vs is DateTimePicker)
            {
                if(Program.GetRole(Properties.Settings.Default.Role) == Role.User)
                {

                    (vs as DateTimePicker).Enabled = false;
                    
                }
            }

            if (vs is Button)
            {
                vs.BackColor = Button_Style.button_backcolor;
                vs.ForeColor = Button_Style.button_forecolor;
                (vs as Button).FlatAppearance.BorderColor = Button_Style.button_bordercolor;
                (vs as Button).FlatAppearance.BorderSize = Button_Style.button_bordersize;
            }
            if (vs is TextBox)
            {
                if (Program.GetRole(Properties.Settings.Default.Role) == Role.User)
                {
                    (vs as TextBox).ReadOnly = true;
                }
            }
            if (vs is Label)
            {
                vs.ForeColor = Label_Style.label_forecolor;
                vs.BackColor = Label_Style.label_backcolor;



            }
            //Для данного элемента не предусмотрен стиль, поэтому добавляем только ограничение для пользователя
            if (vs is ComboBox)
            {
                if (Program.GetRole(Properties.Settings.Default.Role) == Role.User)
                {
                    if ((vs as ComboBox).Enabled)
                        vs.Enabled = false;
                }
            }
            if (vs is BindingNavigator)
            {
                var navigator = (vs as BindingNavigator);
                navigator.BackColor = (vs.FindForm()).BackColor;
                navigator.PositionItem.BackColor = (vs.FindForm()).BackColor;
                navigator.GripStyle = ToolStripGripStyle.Hidden;
                if (navigator.Tag != null && navigator.Tag.ToString().ToUpper() == "ONLY_ADMIN".ToUpper() && Program.GetRole(Properties.Settings.Default.Role) == Role.User)
                {

                    //УБИРАЕМ ДОСТУП К РЕД ФУНКЦИОНАЛУ ДЛЯ ПОЛЬЗОВАТЕЛЯ
                    navigator.AddNewItem.Enabled = false;
                    navigator.DeleteItem.Enabled = false;
                    foreach (Component vsControl in navigator.Items)
                    {
                        if (vsControl is ToolStripButton)
                        {
                            if ((vsControl as ToolStripButton).Name.ToUpper().Contains("BindingNavigatorSaveItem".ToUpper()))
                                (vsControl as ToolStripButton).Enabled = false;
                        }
                    }
                }
            }
            if(vs is DataGridView && false)
            {
                DataGridView DataGrid = (vs as DataGridView);
                DataGrid.EnableHeadersVisualStyles = DataGridView_NoneStyle.EnableHeadersVisualStyles;
                DataGrid.RowHeadersVisible = DataGridView_NoneStyle.RowHeadersVisible;
                DataGrid.AllowUserToAddRows = DataGridView_NoneStyle.AllowUserToAddRows;
                DataGrid.ReadOnly = DataGridView_NoneStyle.ReadOnly;
                DataGrid.AutoSize = DataGridView_NoneStyle.AutoSize;
                DataGrid.SelectionMode = DataGridView_NoneStyle.SelectionMode;
                DataGrid.MultiSelect = DataGridView_NoneStyle.MultiSelect;
                DataGrid.AutoSizeColumnsMode = DataGridView_NoneStyle.AutoSizeColumnsMode;
                DataGrid.AutoSizeRowsMode = DataGridView_NoneStyle.AutoSizeRowsMode;
                DataGrid.CellBorderStyle = DataGridView_NoneStyle.CellBorderStyle;
                DataGrid.AdvancedCellBorderStyle.Left = DataGridView_NoneStyle.AdvancedCellBorderStyleLeft;
                DataGrid.AllowUserToDeleteRows = DataGridView_NoneStyle.AllowUserToDeleteRows;
                DataGrid.AllowUserToOrderColumns = DataGridView_NoneStyle.AllowUserToOrderColumns;
                DataGrid.AllowUserToResizeColumns = DataGridView_NoneStyle.AllowUserToResizeColumns;
                DataGrid.AllowUserToResizeRows = DataGridView_NoneStyle.AllowUserToResizeRows;
                DataGrid.GridColor = (vs.FindForm()).BackColor;
                DataGrid.RowsDefaultCellStyle.BackColor = DataGridView_NoneStyle.BackgroundColor;
                DataGrid.RowsDefaultCellStyle.SelectionForeColor = DataGridView_NoneStyle.SelectionForeColor;
                DataGrid.RowsDefaultCellStyle.SelectionBackColor = DataGridView_NoneStyle.SelectionBackColor;
            }

            //ЛОГИКА TRANSLATE (перевода) ДЛЯ ЛЕНТОЧНЫХ ФОРМ
            if (vs is Label)
            {
                if ((vs.FindForm() != null) && vs.FindForm().AccessibleName != null && (vs.FindForm()).AccessibleName.ToUpper() == "FORM_TRANSLATE")
                {
                    try
                    {
                        if (Program.Translater == null || Program.Translater.Rus == null)
                            throw new Exception("Не удалось найти данные для перевода.");

                        var table = Program.Translater.Rus.Where(x => x.NameTable == vs.FindForm().AccessibleDescription).FirstOrDefault();

                        if (vs.AccessibleDescription != null && !string.IsNullOrWhiteSpace(vs.AccessibleDescription.ToString()))
                        {
                            table = Program.Translater.Rus.Where(x => x.NameTable == vs.AccessibleDescription.ToString()).FirstOrDefault();
                        }

                        if (table == null)
                            throw new Exception($"Warning: не удалось перевести данные для таблица \'{vs.FindForm().AccessibleDescription}\' относительно \'{vs.Name}\'");

                        var property = table.Property.Where(x => x.NameProperty.ToUpper() == vs.Name.ToUpper().Replace("Label".ToUpper(), "")).FirstOrDefault();
                        Debugger.Log(0, "Debug", $"{vs.Name.ToUpper().Replace("Label".ToUpper(), "")}{Environment.NewLine}");
                        if (property != null)
                            vs.Text = property.HeaderProperty;


                    }
                    catch (Exception g)
                    {
                        throw g;
                    }
                }
            }
        }

        /// <summary>
        /// Стат класс для определения стилей DataGridView
        /// </summary>
        private static class DataGridView_NoneStyle
        {
            public static bool EnableHeadersVisualStyles = false;
            public static bool RowHeadersVisible = false;
            public static bool AllowUserToAddRows = false;
            public static bool ReadOnly = false;
            public static bool AutoSize = false;
            public static DataGridViewSelectionMode SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            public static bool MultiSelect = false;
            public static DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            public static DataGridViewAutoSizeRowsMode AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            public static DataGridViewCellBorderStyle CellBorderStyle = DataGridViewCellBorderStyle.None;
            public static DataGridViewAdvancedCellBorderStyle AdvancedCellBorderStyleLeft = DataGridViewAdvancedCellBorderStyle.OutsetPartial;
            public static bool AllowUserToDeleteRows = false;
            public static bool AllowUserToOrderColumns = false;
            public static bool AllowUserToResizeColumns = false;
            public static bool AllowUserToResizeRows = false;

            public static Color SelectionForeColor = Color.Transparent;
            public static Color SelectionBackColor = Color.Transparent;
            public static Color BackgroundColor = Color.Transparent;
            public static bool ColumnHeadersVisible = false;
        }
        /// <summary>
        /// Стат класс для определения стилей кнопки
        /// </summary>
        private static class Button_Style
        {
            public static Color button_forecolor = Color.Black;
            public static Color button_backcolor = Color.Transparent;
            public static int button_bordersize = 1;
            public static Color button_bordercolor = Color.FromArgb(0, 192, 192);
        }

        /// <summary>
        /// Стат класс для определения стилей текста Label (Если иные не описаны то стили в Designer.cs)
        /// </summary>
        private static class Label_Style
        {
            public static Color label_forecolor = Color.Black;
            public static Color label_backcolor = Color.Transparent;
        }


    }
}
