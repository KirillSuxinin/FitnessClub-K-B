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
    public partial class ChangeStructureOutputTableForm : Form
    {
        public ChangeStructureOutputTableForm(List<string> columns, List<string> OneRow)
        {
            InitializeComponent();
            dynamic_style.Enable(this);
            //Добавление в datagridview и listbox
            foreach (var v in columns)
            {
                listBox1.Items.Add(v);
                dataGridView1.Columns.Add(v, v);
            }



            //assuming that you created columns (via code or designer) in myDGV
            //  DataGridViewRow row = (DataGridViewRow)dataGridView1.RowTemplate.Clone();
            //row.CreateCells(dataGridView1,OneRow);
            dataGridView1.Rows.Add(1);
            for (int i = 0; i < columns.Count; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = OneRow[i];
            }
        }

        /// <summary>
        /// Результат Name столбцов которые имеют свойство отображатся 
        /// </summary>
        public List<string> Result
        {
            get
            {
                return dataGridView1.Columns.Cast<DataGridViewColumn>().Where(x => x.Visible).Select(x => x.Name).ToList();
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                dataGridView1.Columns[listBox1.SelectedIndex].Visible = false;
                if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                    listBox1.SelectedIndex++;

                else
                    listBox1.SelectedIndex = 0;
                listBox1.Focus();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                dataGridView1.Columns[listBox1.SelectedIndex].Visible = true;
                if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                    listBox1.SelectedIndex++;
                else
                    listBox1.SelectedIndex = 0;
                listBox1.Focus();
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                dataGridView1.Columns[listBox1.SelectedIndex].Visible = !dataGridView1.Columns[listBox1.SelectedIndex].Visible;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
