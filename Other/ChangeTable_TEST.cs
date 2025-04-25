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
    public partial class ChangeTable_TEST : Form
    {
        public ChangeTable_TEST()
        {
            InitializeComponent();
        }

        private async void ChangeTable_TEST_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            await Task.Run(() =>
            {
                var table = Program.Select("Select TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'");

                comboBox1.Invoke(new Action(() =>
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        comboBox1.Items.Add(table.Rows[i].ItemArray[0].ToString());
                    }
                }));

            });
        }

        public string ReturnText
        {
            get
            {
                return comboBox1.Items[comboBox1.SelectedIndex].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                return;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
