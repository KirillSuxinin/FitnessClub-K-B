namespace FitnessClub.Lenta
{
    partial class Trainers_Form
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
            System.Windows.Forms.Label trainerIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label specializationLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainers_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fitnessClubDataSet = new FitnessClub.FitnessClubDataSet();
            this.trainersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainersTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.TrainersTableAdapter();
            this.tableAdapterManager = new FitnessClub.FitnessClubDataSetTableAdapters.TableAdapterManager();
            this.classEquipmentTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.ClassEquipmentTableAdapter();
            this.classesTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.ClassesTableAdapter();
            this.trainersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trainersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.trainerIDComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.specializationTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGrid_classe_by_trainer = new System.Windows.Forms.DataGridView();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSorting = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.fKClassEquiClass4E88ABD4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.imgCombo = new System.Windows.Forms.ComboBox();
            this.imagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imagesTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.ImagesTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            trainerIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            specializationLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingNavigator)).BeginInit();
            this.trainersBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_classe_by_trainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClassEquiClass4E88ABD4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trainerIDLabel
            // 
            trainerIDLabel.AutoSize = true;
            trainerIDLabel.Location = new System.Drawing.Point(10, 42);
            trainerIDLabel.Name = "trainerIDLabel";
            trainerIDLabel.Size = new System.Drawing.Size(57, 13);
            trainerIDLabel.TabIndex = 1;
            trainerIDLabel.Text = "Trainer ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(10, 69);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(10, 95);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // specializationLabel
            // 
            specializationLabel.AutoSize = true;
            specializationLabel.Location = new System.Drawing.Point(10, 121);
            specializationLabel.Name = "specializationLabel";
            specializationLabel.Size = new System.Drawing.Size(75, 13);
            specializationLabel.TabIndex = 7;
            specializationLabel.Text = "Specialization:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(10, 147);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(10, 173);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // fitnessClubDataSet
            // 
            this.fitnessClubDataSet.DataSetName = "FitnessClubDataSet";
            this.fitnessClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainersBindingSource
            // 
            this.trainersBindingSource.DataMember = "Trainers";
            this.trainersBindingSource.DataSource = this.fitnessClubDataSet;
            this.trainersBindingSource.CurrentChanged += new System.EventHandler(this.trainersBindingSource_CurrentChanged);
            this.trainersBindingSource.CurrentItemChanged += new System.EventHandler(this.trainersBindingSource_CurrentItemChanged);
            this.trainersBindingSource.PositionChanged += new System.EventHandler(this.trainersBindingSource_PositionChanged);
            // 
            // trainersTableAdapter
            // 
            this.trainersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassEquipmentTableAdapter = this.classEquipmentTableAdapter;
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
            // classEquipmentTableAdapter
            // 
            this.classEquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // trainersBindingNavigator
            // 
            this.trainersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.trainersBindingNavigator.BackColor = System.Drawing.Color.Red;
            this.trainersBindingNavigator.BindingSource = this.trainersBindingSource;
            this.trainersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.trainersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.trainersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.trainersBindingNavigatorSaveItem});
            this.trainersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.trainersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.trainersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.trainersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.trainersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.trainersBindingNavigator.Name = "trainersBindingNavigator";
            this.trainersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.trainersBindingNavigator.Size = new System.Drawing.Size(756, 25);
            this.trainersBindingNavigator.TabIndex = 0;
            this.trainersBindingNavigator.Tag = "ONLY_ADMIN";
            this.trainersBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.Color.Red;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // trainersBindingNavigatorSaveItem
            // 
            this.trainersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.trainersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("trainersBindingNavigatorSaveItem.Image")));
            this.trainersBindingNavigatorSaveItem.Name = "trainersBindingNavigatorSaveItem";
            this.trainersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.trainersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.trainersBindingNavigatorSaveItem.Click += new System.EventHandler(this.trainersBindingNavigatorSaveItem_Click);
            // 
            // trainerIDComboBox
            // 
            this.trainerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "TrainerID", true));
            this.trainerIDComboBox.FormattingEnabled = true;
            this.trainerIDComboBox.Location = new System.Drawing.Point(115, 39);
            this.trainerIDComboBox.Name = "trainerIDComboBox";
            this.trainerIDComboBox.Size = new System.Drawing.Size(154, 21);
            this.trainerIDComboBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(115, 66);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(115, 92);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // specializationTextBox
            // 
            this.specializationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "Specialization", true));
            this.specializationTextBox.Location = new System.Drawing.Point(115, 118);
            this.specializationTextBox.Name = "specializationTextBox";
            this.specializationTextBox.Size = new System.Drawing.Size(154, 20);
            this.specializationTextBox.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(115, 144);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(154, 20);
            this.phoneTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(115, 170);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(154, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGrid_classe_by_trainer);
            this.groupBox1.Location = new System.Drawing.Point(463, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 193);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Курсы тренера";
            // 
            // dataGrid_classe_by_trainer
            // 
            this.dataGrid_classe_by_trainer.AccessibleName = "";
            this.dataGrid_classe_by_trainer.AllowUserToAddRows = false;
            this.dataGrid_classe_by_trainer.AllowUserToDeleteRows = false;
            this.dataGrid_classe_by_trainer.AllowUserToResizeRows = false;
            this.dataGrid_classe_by_trainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_classe_by_trainer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_classe_by_trainer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_classe_by_trainer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_classe_by_trainer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_classe_by_trainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_classe_by_trainer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_classe_by_trainer.EnableHeadersVisualStyles = false;
            this.dataGrid_classe_by_trainer.Location = new System.Drawing.Point(6, 19);
            this.dataGrid_classe_by_trainer.MultiSelect = false;
            this.dataGrid_classe_by_trainer.Name = "dataGrid_classe_by_trainer";
            this.dataGrid_classe_by_trainer.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_classe_by_trainer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_classe_by_trainer.RowHeadersVisible = false;
            this.dataGrid_classe_by_trainer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_classe_by_trainer.ShowCellErrors = false;
            this.dataGrid_classe_by_trainer.ShowCellToolTips = false;
            this.dataGrid_classe_by_trainer.ShowEditingIcon = false;
            this.dataGrid_classe_by_trainer.Size = new System.Drawing.Size(263, 159);
            this.dataGrid_classe_by_trainer.TabIndex = 0;
            this.dataGrid_classe_by_trainer.Tag = "";
            this.dataGrid_classe_by_trainer.SizeChanged += new System.EventHandler(this.dataGrid_classe_by_trainer_SizeChanged);
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.fitnessClubDataSet;
            // 
            // btnFirst
            // 
            this.btnFirst.AccessibleName = "NONESTYLE";
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(13, 248);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(92, 23);
            this.btnFirst.TabIndex = 14;
            this.btnFirst.Text = "Перв. запись";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.AccessibleName = "NONESTYLE";
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(111, 248);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(92, 23);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = "Пред. запись";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.AccessibleName = "NONESTYLE";
            this.btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Location = new System.Drawing.Point(548, 248);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(92, 23);
            this.btn_Next.TabIndex = 14;
            this.btn_Next.Text = "След. запись";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_last
            // 
            this.btn_last.AccessibleName = "NONESTYLE";
            this.btn_last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_last.Location = new System.Drawing.Point(646, 248);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(92, 23);
            this.btn_last.TabIndex = 14;
            this.btn_last.Text = "Посл. запись";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "NONESTYLE";
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(13, 294);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "ONLY_ADMIN";
            this.btnCancel.AccessibleName = "NONESTYLE";
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(299, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Отменить изменения";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSorting
            // 
            this.btnSorting.AccessibleName = "NONESTYLE";
            this.btnSorting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSorting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorting.Location = new System.Drawing.Point(111, 294);
            this.btnSorting.Name = "btnSorting";
            this.btnSorting.Size = new System.Drawing.Size(111, 23);
            this.btnSorting.TabIndex = 14;
            this.btnSorting.Text = "Сортировка";
            this.btnSorting.UseVisualStyleBackColor = true;
            this.btnSorting.Click += new System.EventHandler(this.btnSorting_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleDescription = "ONLY_ADMIN";
            this.btnSave.AccessibleName = "NONESTYLE";
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(646, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "ONLY_ADMIN";
            this.btnAdd.AccessibleName = "NONESTYLE";
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(548, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = "ONLY_ADMIN";
            this.btnDelete.AccessibleName = "NONESTYLE";
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(450, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // fKClassEquiClass4E88ABD4BindingSource
            // 
            this.fKClassEquiClass4E88ABD4BindingSource.DataMember = "FK__ClassEqui__Class__4E88ABD4";
            this.fKClassEquiClass4E88ABD4BindingSource.DataSource = this.classesBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Изображение:";
            // 
            // imgCombo
            // 
            this.imgCombo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "ImageID", true));
            this.imgCombo.DataSource = this.imagesBindingSource;
            this.imgCombo.DisplayMember = "ImageID";
            this.imgCombo.FormattingEnabled = true;
            this.imgCombo.Location = new System.Drawing.Point(115, 196);
            this.imgCombo.Name = "imgCombo";
            this.imgCombo.Size = new System.Drawing.Size(154, 21);
            this.imgCombo.TabIndex = 16;
            this.imgCombo.SelectedIndexChanged += new System.EventHandler(this.imgCombo_SelectedIndexChanged);
            // 
            // imagesBindingSource
            // 
            this.imagesBindingSource.DataMember = "Images";
            this.imagesBindingSource.DataSource = this.fitnessClubDataSet;
            // 
            // imagesTableAdapter
            // 
            this.imagesTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(277, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Trainers_Form
            // 
            this.AccessibleDescription = "Trainers";
            this.AccessibleName = "FORM_TRANSLATE";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(756, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSorting);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(trainerIDLabel);
            this.Controls.Add(this.trainerIDComboBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(specializationLabel);
            this.Controls.Add(this.specializationTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.trainersBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(772, 368);
            this.Name = "Trainers_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "SAVE_SIZE";
            this.Text = "Тренеры";
            this.Load += new System.EventHandler(this.Trainers_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingNavigator)).EndInit();
            this.trainersBindingNavigator.ResumeLayout(false);
            this.trainersBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_classe_by_trainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClassEquiClass4E88ABD4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FitnessClubDataSet fitnessClubDataSet;
        private System.Windows.Forms.BindingSource trainersBindingSource;
        private FitnessClubDataSetTableAdapters.TrainersTableAdapter trainersTableAdapter;
        private FitnessClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator trainersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton trainersBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox trainerIDComboBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox specializationTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGrid_classe_by_trainer;
        private FitnessClubDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private FitnessClubDataSetTableAdapters.ClassEquipmentTableAdapter classEquipmentTableAdapter;
        private System.Windows.Forms.BindingSource fKClassEquiClass4E88ABD4BindingSource;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSorting;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox imgCombo;
        private System.Windows.Forms.BindingSource imagesBindingSource;
        private FitnessClubDataSetTableAdapters.ImagesTableAdapter imagesTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}