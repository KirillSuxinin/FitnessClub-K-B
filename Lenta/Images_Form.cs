using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub.Lenta
{
    public partial class Images_Form : Form
    {
        public Images_Form()
        {
            InitializeComponent();
            dynamic_style.Enable(this);
        }

        private void Images_Form_Load(object sender, EventArgs e)
        {
            LoadImages();
        }

        private void LoadImages()
        {
            txtCodeImage.Text = "";
            pictureBox1.Image = null;
            listView1.Items.Clear();
            ImageList img = new ImageList();
            img.ImageSize = new Size(32, 32);
            listView1.LargeImageList = img;
            foreach (var vs in Program.Images)
            {

                img.Images.Add(vs.Key.ToString(), vs.Value);
                
                ListViewItem it = new ListViewItem(vs.Key.ToString(), vs.Key.ToString());
                listView1.Items.Add(it);
                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems != null)
            {
                try
                {
                   // MessageBox.Show((listView1.SelectedItems.Count).ToString());
                    pictureBox1.Image = Program.Images.Where(x => x.Key == int.Parse((listView1.SelectedItems[0] as ListViewItem).ImageKey)).FirstOrDefault().Value;
                    txtCodeImage.Text = Program.Images.Where(x => x.Key == int.Parse((listView1.SelectedItems[0] as ListViewItem).ImageKey)).FirstOrDefault().Key.ToString();
                }
                catch(Exception g)
                {
                   // Debugger.Log(1, "Debug/File", g.ToString());
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
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
                        Program.ThreadLoadImage = new System.Threading.Thread(Program.UpdateImage);
                        Program.ThreadLoadImage.Start();
                        await Task.Run(async () =>
                        {
                            while (Program.ThreadLoadImage.IsAlive)
                            {
                                await Task.Delay(100);
                            }
                            this.Invoke(new Action(() =>
                            {
                                LoadImages();
                            }));
                        });
                        MessageBox.Show(this, "Изображение успешно добавлено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(this, $"Данное изображение уже существует в базе.\nИдентификатор: {data.Rows[0].ItemArray[0].ToString()}", "Не удалось добавить", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception g)
                {
                    MessageBox.Show(g.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int identify = int.Parse(txtCodeImage.Text);
                if(MessageBox.Show(this,"Вы уверены что хотите удалить изображение под кодом: " + identify + " ?","Подтвердите",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var sql = "DELETE FROM Images WHERE ImageID = " + identify;
                    int result = Program.Insert(sql);
                    
                    Program.ThreadLoadImage = new System.Threading.Thread(Program.UpdateImage);
                    Program.ThreadLoadImage.Start();
                    await Task.Run(async () =>
                    {
                        while (Program.ThreadLoadImage.IsAlive)
                        {
                            await Task.Delay(100);
                        }
                        this.Invoke(new Action(() =>
                        {
                            LoadImages();
                            MessageBox.Show(this, "Список изображений обновлен успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }));
                    });
                }
            }
            catch(Exception g)
            {
                MessageBox.Show(g.Message, "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                int identify = int.Parse(txtCodeImage.Text);
                if (MessageBox.Show(this, "Вы уверены что хотите заменить изображение под кодом: " + identify + " ?", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OpenFileDialog open = new OpenFileDialog();
                    open.Filter = "Image PNG|*.PNG|Image JPG|*.JPG|All Files|*.*";
                    if (open.ShowDialog(this) == DialogResult.OK)
                    {
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
                            //HERE UPDATE SQL
                            string update = $"UPDATE Images SET ImageBase64 = \'{base64}\' WHERE ImageID = {identify}";
                            int sql_result = Program.Insert(update);
                            MessageBox.Show(sql_result.ToString());
                            Program.ThreadLoadImage = new System.Threading.Thread(Program.UpdateImage);
                            Program.ThreadLoadImage.Start();
                            await Task.Run(async () =>
                            {
                                while (Program.ThreadLoadImage.IsAlive)
                                {
                                    await Task.Delay(100);
                                }
                                this.Invoke(new Action(() =>
                                {
                                    LoadImages();
                                    MessageBox.Show(this, "Список изображений обновлен успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }));
                            });
                        }
                        else
                        {
                            MessageBox.Show(this, $"Данное изображение уже существует в базе.\nИдентификатор: {data.Rows[0].ItemArray[0].ToString()}", "Не удалось заменить", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message, "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
