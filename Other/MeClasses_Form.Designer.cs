namespace FitnessClub.Other
{
    partial class MeClasses_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeClasses_Form));
            this.lst_classes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDayOfWeeks = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailTrainer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumberTrainer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameSurnameTrainer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chartGrid1 = new ChartGrid.ChartGrid();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_classes
            // 
            this.lst_classes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_classes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lst_classes.FormattingEnabled = true;
            this.lst_classes.ItemHeight = 19;
            this.lst_classes.Location = new System.Drawing.Point(12, 12);
            this.lst_classes.Name = "lst_classes";
            this.lst_classes.Size = new System.Drawing.Size(298, 175);
            this.lst_classes.TabIndex = 1;
            this.lst_classes.SelectedIndexChanged += new System.EventHandler(this.lst_classes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Недельный график";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnBack.Location = new System.Drawing.Point(12, 452);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 31);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtEnd);
            this.groupBox1.Controls.Add(this.txtStart);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSpecialization);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDayOfWeeks);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmailTrainer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNumberTrainer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNameSurnameTrainer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(316, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 194);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "О занятии";
            // 
            // txtEnd
            // 
            this.txtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnd.Location = new System.Drawing.Point(217, 103);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.ReadOnly = true;
            this.txtEnd.Size = new System.Drawing.Size(82, 20);
            this.txtEnd.TabIndex = 1;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(106, 103);
            this.txtStart.Name = "txtStart";
            this.txtStart.ReadOnly = true;
            this.txtStart.Size = new System.Drawing.Size(86, 20);
            this.txtStart.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Начало -";
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpecialization.Location = new System.Drawing.Point(106, 155);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.ReadOnly = true;
            this.txtSpecialization.Size = new System.Drawing.Size(193, 20);
            this.txtSpecialization.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Специализация -";
            // 
            // txtDayOfWeeks
            // 
            this.txtDayOfWeeks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDayOfWeeks.Location = new System.Drawing.Point(106, 129);
            this.txtDayOfWeeks.Name = "txtDayOfWeeks";
            this.txtDayOfWeeks.ReadOnly = true;
            this.txtDayOfWeeks.Size = new System.Drawing.Size(193, 20);
            this.txtDayOfWeeks.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "День недели-";
            // 
            // txtEmailTrainer
            // 
            this.txtEmailTrainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailTrainer.Location = new System.Drawing.Point(106, 77);
            this.txtEmailTrainer.Name = "txtEmailTrainer";
            this.txtEmailTrainer.ReadOnly = true;
            this.txtEmailTrainer.Size = new System.Drawing.Size(193, 20);
            this.txtEmailTrainer.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email -";
            // 
            // txtNumberTrainer
            // 
            this.txtNumberTrainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberTrainer.Location = new System.Drawing.Point(106, 45);
            this.txtNumberTrainer.Name = "txtNumberTrainer";
            this.txtNumberTrainer.ReadOnly = true;
            this.txtNumberTrainer.Size = new System.Drawing.Size(193, 20);
            this.txtNumberTrainer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Номер -";
            // 
            // txtNameSurnameTrainer
            // 
            this.txtNameSurnameTrainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameSurnameTrainer.Location = new System.Drawing.Point(106, 19);
            this.txtNameSurnameTrainer.Name = "txtNameSurnameTrainer";
            this.txtNameSurnameTrainer.ReadOnly = true;
            this.txtNameSurnameTrainer.Size = new System.Drawing.Size(193, 20);
            this.txtNameSurnameTrainer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тренер -";
            // 
            // chartGrid1
            // 
            this.chartGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartGrid1.Location = new System.Drawing.Point(16, 232);
            this.chartGrid1.MinimumSize = new System.Drawing.Size(50, 50);
            this.chartGrid1.Name = "chartGrid1";
            this.chartGrid1.Size = new System.Drawing.Size(599, 198);
            this.chartGrid1.TabIndex = 7;
            // 
            // MeClasses_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(633, 495);
            this.Controls.Add(this.chartGrid1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_classes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(649, 508);
            this.Name = "MeClasses_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "save_size";
            this.Text = "Мои занятия";
            this.Load += new System.EventHandler(this.MeClasses_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_classes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmailTrainer;
        private System.Windows.Forms.TextBox txtNumberTrainer;
        private System.Windows.Forms.TextBox txtNameSurnameTrainer;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDayOfWeeks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.Label label9;
        private ChartGrid.ChartGrid chartGrid1;
    }
}