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
    public partial class Class_Trainers_Equipment_Form : Form
    {
        public Class_Trainers_Equipment_Form()
        {
            InitializeComponent();
            dynamic_style.Enable(this);
        }

        private void classesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.classesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.fitnessClubDataSet);
            }
            catch(Exception g)
            {

            }

        }

        private void Class_Trainers_Equipment_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Trainers". При необходимости она может быть перемещена или удалена.
            this.trainersTableAdapter.Fill(this.fitnessClubDataSet.Trainers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet.Classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.fitnessClubDataSet.Classes);

        }

        private void classesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                if (Program.Images.Where(x => x.Key.ToString() == comboBox1.Text).Count() > 0)
                    pictureBox1.Image = Program.Images[int.Parse(comboBox1.Text)];
            }


            int id_classes = int.Parse(classIDComboBox.Text);
            listBox1.Items.Clear();
            var dataClassEquipment = Program.Select_Dynamic($"SELECT * FROM ClassEquipment WHERE ClassID = {id_classes}");
            foreach(var id_equi in dataClassEquipment)
            {
                var equipment = Program.Select_Dynamic($"SELECT * FROM Equipment WHERE EquipmentID = {id_equi.EquipmentID}");
                foreach(var vs in equipment)
                {
                    listBox1.Items.Add($"{vs.Name} | Тип: {vs.Type}");
                }
            }
        }
    }
}
