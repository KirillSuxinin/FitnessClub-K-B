namespace FitnessClub.Lenta
{
    partial class Class_Trainers_Equipment_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class_Trainers_Equipment_Form));
            System.Windows.Forms.Label classIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label trainerIDLabel;
            System.Windows.Forms.Label maxCapacityLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label dayOfWeekLabel;
            this.fitnessClubDataSet = new FitnessClub.FitnessClubDataSet();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.ClassesTableAdapter();
            this.tableAdapterManager = new FitnessClub.FitnessClubDataSetTableAdapters.TableAdapterManager();
            this.classesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.classesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.classIDComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.trainerIDComboBox = new System.Windows.Forms.ComboBox();
            this.maxCapacityTextBox = new System.Windows.Forms.TextBox();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.dayOfWeekComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trainersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainersTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.TrainersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            classIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            trainerIDLabel = new System.Windows.Forms.Label();
            maxCapacityLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            dayOfWeekLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingNavigator)).BeginInit();
            this.classesBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fitnessClubDataSet
            // 
            this.fitnessClubDataSet.DataSetName = "FitnessClubDataSet";
            this.fitnessClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.fitnessClubDataSet;
            this.classesBindingSource.PositionChanged += new System.EventHandler(this.classesBindingSource_PositionChanged);
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassEquipmentTableAdapter = null;
            this.tableAdapterManager.ClassesTableAdapter = this.classesTableAdapter;
            this.tableAdapterManager.ClassSchedulesTableAdapter = null;
            this.tableAdapterManager.ClientClassRegistrationsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.ImagesTableAdapter = null;
            this.tableAdapterManager.MembershipsTableAdapter = null;
            this.tableAdapterManager.MembershipTypesTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.TrainersTableAdapter = this.trainersTableAdapter;
            this.tableAdapterManager.UpdateOrder = FitnessClub.FitnessClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // classesBindingNavigator
            // 
            this.classesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.classesBindingNavigator.BindingSource = this.classesBindingSource;
            this.classesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.classesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.classesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.classesBindingNavigatorSaveItem});
            this.classesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.classesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.classesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.classesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.classesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.classesBindingNavigator.Name = "classesBindingNavigator";
            this.classesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.classesBindingNavigator.Size = new System.Drawing.Size(765, 25);
            this.classesBindingNavigator.TabIndex = 0;
            this.classesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // classesBindingNavigatorSaveItem
            // 
            this.classesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.classesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("classesBindingNavigatorSaveItem.Image")));
            this.classesBindingNavigatorSaveItem.Name = "classesBindingNavigatorSaveItem";
            this.classesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.classesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.classesBindingNavigatorSaveItem.Click += new System.EventHandler(this.classesBindingNavigatorSaveItem_Click);
            // 
            // classIDLabel
            // 
            classIDLabel.AutoSize = true;
            classIDLabel.Location = new System.Drawing.Point(17, 30);
            classIDLabel.Name = "classIDLabel";
            classIDLabel.Size = new System.Drawing.Size(49, 13);
            classIDLabel.TabIndex = 1;
            classIDLabel.Text = "Class ID:";
            // 
            // classIDComboBox
            // 
            this.classIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "ClassID", true));
            this.classIDComboBox.FormattingEnabled = true;
            this.classIDComboBox.Location = new System.Drawing.Point(151, 27);
            this.classIDComboBox.Name = "classIDComboBox";
            this.classIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.classIDComboBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(17, 57);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(151, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(17, 83);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(151, 80);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(121, 20);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // trainerIDLabel
            // 
            trainerIDLabel.AutoSize = true;
            trainerIDLabel.Location = new System.Drawing.Point(17, 109);
            trainerIDLabel.Name = "trainerIDLabel";
            trainerIDLabel.Size = new System.Drawing.Size(57, 13);
            trainerIDLabel.TabIndex = 7;
            trainerIDLabel.Text = "Trainer ID:";
            // 
            // trainerIDComboBox
            // 
            this.trainerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "TrainerID", true));
            this.trainerIDComboBox.DataSource = this.trainersBindingSource;
            this.trainerIDComboBox.DisplayMember = "TrainerID";
            this.trainerIDComboBox.FormattingEnabled = true;
            this.trainerIDComboBox.Location = new System.Drawing.Point(151, 106);
            this.trainerIDComboBox.Name = "trainerIDComboBox";
            this.trainerIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.trainerIDComboBox.TabIndex = 8;
            // 
            // maxCapacityLabel
            // 
            maxCapacityLabel.AutoSize = true;
            maxCapacityLabel.Location = new System.Drawing.Point(17, 136);
            maxCapacityLabel.Name = "maxCapacityLabel";
            maxCapacityLabel.Size = new System.Drawing.Size(74, 13);
            maxCapacityLabel.TabIndex = 9;
            maxCapacityLabel.Text = "Max Capacity:";
            // 
            // maxCapacityTextBox
            // 
            this.maxCapacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "MaxCapacity", true));
            this.maxCapacityTextBox.Location = new System.Drawing.Point(151, 133);
            this.maxCapacityTextBox.Name = "maxCapacityTextBox";
            this.maxCapacityTextBox.Size = new System.Drawing.Size(121, 20);
            this.maxCapacityTextBox.TabIndex = 10;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(17, 162);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(58, 13);
            startTimeLabel.TabIndex = 11;
            startTimeLabel.Text = "Start Time:";
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "StartTime", true));
            this.startTimeTextBox.Location = new System.Drawing.Point(151, 159);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(121, 20);
            this.startTimeTextBox.TabIndex = 12;
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(17, 188);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(55, 13);
            endTimeLabel.TabIndex = 13;
            endTimeLabel.Text = "End Time:";
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "EndTime", true));
            this.endTimeTextBox.Location = new System.Drawing.Point(151, 185);
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.Size = new System.Drawing.Size(121, 20);
            this.endTimeTextBox.TabIndex = 14;
            // 
            // dayOfWeekLabel
            // 
            dayOfWeekLabel.AutoSize = true;
            dayOfWeekLabel.Location = new System.Drawing.Point(17, 214);
            dayOfWeekLabel.Name = "dayOfWeekLabel";
            dayOfWeekLabel.Size = new System.Drawing.Size(75, 13);
            dayOfWeekLabel.TabIndex = 15;
            dayOfWeekLabel.Text = "Day Of Week:";
            // 
            // dayOfWeekComboBox
            // 
            this.dayOfWeekComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "DayOfWeek", true));
            this.dayOfWeekComboBox.FormattingEnabled = true;
            this.dayOfWeekComboBox.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.dayOfWeekComboBox.Location = new System.Drawing.Point(151, 211);
            this.dayOfWeekComboBox.Name = "dayOfWeekComboBox";
            this.dayOfWeekComboBox.Size = new System.Drawing.Size(121, 21);
            this.dayOfWeekComboBox.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(classIDLabel);
            this.groupBox1.Controls.Add(this.dayOfWeekComboBox);
            this.groupBox1.Controls.Add(this.classIDComboBox);
            this.groupBox1.Controls.Add(dayOfWeekLabel);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.endTimeTextBox);
            this.groupBox1.Controls.Add(endTimeLabel);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.startTimeTextBox);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(startTimeLabel);
            this.groupBox1.Controls.Add(trainerIDLabel);
            this.groupBox1.Controls.Add(this.maxCapacityTextBox);
            this.groupBox1.Controls.Add(this.trainerIDComboBox);
            this.groupBox1.Controls.Add(maxCapacityLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 359);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Занятие";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(294, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 213);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тренер";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(20, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(715, 115);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оборудование";
            // 
            // trainersBindingSource
            // 
            this.trainersBindingSource.DataMember = "Trainers";
            this.trainersBindingSource.DataSource = this.fitnessClubDataSet;
            // 
            // trainersTableAdapter
            // 
            this.trainersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код -";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "TrainerID", true));
            this.textBox1.Location = new System.Drawing.Point(111, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "FirstName", true));
            this.textBox2.Location = new System.Drawing.Point(111, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "LastName", true));
            this.textBox3.Location = new System.Drawing.Point(111, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Фамилия -";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "Specialization", true));
            this.textBox4.Location = new System.Drawing.Point(111, 91);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 20);
            this.textBox4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Специализация -";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "Phone", true));
            this.textBox5.Location = new System.Drawing.Point(111, 117);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(152, 20);
            this.textBox5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Номер телефона -";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "Email", true));
            this.textBox6.Location = new System.Drawing.Point(111, 143);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(152, 20);
            this.textBox6.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Эл.  Почта  -";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "ImageID", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Изображение -";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(703, 84);
            this.listBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(269, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Class_Trainers_Equipment_Form
            // 
            this.AccessibleDescription = "Classes";
            this.AccessibleName = "FORM_TRANSLATE";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(765, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.classesBindingNavigator);
            this.Name = "Class_Trainers_Equipment_Form";
            this.Text = "О занятие";
            this.Load += new System.EventHandler(this.Class_Trainers_Equipment_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingNavigator)).EndInit();
            this.classesBindingNavigator.ResumeLayout(false);
            this.classesBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FitnessClubDataSet fitnessClubDataSet;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private FitnessClubDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private FitnessClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator classesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton classesBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox classIDComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox trainerIDComboBox;
        private System.Windows.Forms.TextBox maxCapacityTextBox;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.ComboBox dayOfWeekComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private FitnessClubDataSetTableAdapters.TrainersTableAdapter trainersTableAdapter;
        private System.Windows.Forms.BindingSource trainersBindingSource;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}