namespace FitnessClub.Lenta
{
    partial class Membershis_Form
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
            System.Windows.Forms.Label membershipIDLabel;
            System.Windows.Forms.Label clientIDLabel;
            System.Windows.Forms.Label membershipTypeIDLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membershis_Form));
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSorting = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.fitnessClubDataSet = new FitnessClub.FitnessClubDataSet();
            this.membershipsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membershipsTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.MembershipsTableAdapter();
            this.tableAdapterManager = new FitnessClub.FitnessClubDataSetTableAdapters.TableAdapterManager();
            this.membershipsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.membershipsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.membershipIDComboBox = new System.Windows.Forms.ComboBox();
            this.clientIDComboBox = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membershipTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.membershipTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_client_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_client_date = new System.Windows.Forms.TextBox();
            this.txt_client_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_client_surname = new System.Windows.Forms.TextBox();
            this.txt_client_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientsTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.ClientsTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.membershipTypesTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.MembershipTypesTableAdapter();
            this.btnSortWithForeign = new System.Windows.Forms.Button();
            membershipIDLabel = new System.Windows.Forms.Label();
            clientIDLabel = new System.Windows.Forms.Label();
            membershipTypeIDLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipsBindingNavigator)).BeginInit();
            this.membershipsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipTypesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // membershipIDLabel
            // 
            membershipIDLabel.AutoSize = true;
            membershipIDLabel.Location = new System.Drawing.Point(0, 31);
            membershipIDLabel.Name = "membershipIDLabel";
            membershipIDLabel.Size = new System.Drawing.Size(81, 13);
            membershipIDLabel.TabIndex = 35;
            membershipIDLabel.Text = "Membership ID:";
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(0, 58);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(50, 13);
            clientIDLabel.TabIndex = 37;
            clientIDLabel.Text = "Client ID:";
            // 
            // membershipTypeIDLabel
            // 
            membershipTypeIDLabel.AutoSize = true;
            membershipTypeIDLabel.Location = new System.Drawing.Point(0, 85);
            membershipTypeIDLabel.Name = "membershipTypeIDLabel";
            membershipTypeIDLabel.Size = new System.Drawing.Size(108, 13);
            membershipTypeIDLabel.TabIndex = 39;
            membershipTypeIDLabel.Text = "Membership Type ID:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(0, 113);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(58, 13);
            startDateLabel.TabIndex = 41;
            startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(0, 139);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(55, 13);
            endDateLabel.TabIndex = 43;
            endDateLabel.Text = "End Date:";
            // 
            // btn_last
            // 
            this.btn_last.AccessibleName = "NONESTYLE";
            this.btn_last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_last.Location = new System.Drawing.Point(567, 313);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(92, 23);
            this.btn_last.TabIndex = 25;
            this.btn_last.Text = "Посл. запись";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.AccessibleName = "NONESTYLE";
            this.btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Location = new System.Drawing.Point(469, 313);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(92, 23);
            this.btn_Next.TabIndex = 26;
            this.btn_Next.Text = "След. запись";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.AccessibleName = "NONESTYLE";
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(114, 313);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(92, 23);
            this.btnPrev.TabIndex = 27;
            this.btnPrev.Text = "Пред. запись";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "ONLY_ADMIN";
            this.btnCancel.AccessibleName = "NONESTYLE";
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(261, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Отменить изменения";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSorting
            // 
            this.btnSorting.AccessibleName = "NONESTYLE";
            this.btnSorting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSorting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorting.Location = new System.Drawing.Point(114, 359);
            this.btnSorting.Name = "btnSorting";
            this.btnSorting.Size = new System.Drawing.Size(111, 23);
            this.btnSorting.TabIndex = 29;
            this.btnSorting.Text = "Сортировка";
            this.btnSorting.UseVisualStyleBackColor = true;
            this.btnSorting.Click += new System.EventHandler(this.btnSorting_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = "ONLY_ADMIN";
            this.btnDelete.AccessibleName = "NONESTYLE";
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(371, 359);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 23);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "ONLY_ADMIN";
            this.btnAdd.AccessibleName = "NONESTYLE";
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(469, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleDescription = "ONLY_ADMIN";
            this.btnSave.AccessibleName = "NONESTYLE";
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(567, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 23);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "NONESTYLE";
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(16, 359);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 23);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.AccessibleName = "NONESTYLE";
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(16, 313);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(92, 23);
            this.btnFirst.TabIndex = 34;
            this.btnFirst.Text = "Перв. запись";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // fitnessClubDataSet
            // 
            this.fitnessClubDataSet.DataSetName = "FitnessClubDataSet";
            this.fitnessClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membershipsBindingSource
            // 
            this.membershipsBindingSource.DataMember = "Memberships";
            this.membershipsBindingSource.DataSource = this.fitnessClubDataSet;
            // 
            // membershipsTableAdapter
            // 
            this.membershipsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassEquipmentTableAdapter = null;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.ClassSchedulesTableAdapter = null;
            this.tableAdapterManager.ClientClassRegistrationsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.ImagesTableAdapter = null;
            this.tableAdapterManager.MembershipsTableAdapter = this.membershipsTableAdapter;
            this.tableAdapterManager.MembershipTypesTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.TrainersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FitnessClub.FitnessClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // membershipsBindingNavigator
            // 
            this.membershipsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.membershipsBindingNavigator.BackColor = System.Drawing.Color.Red;
            this.membershipsBindingNavigator.BindingSource = this.membershipsBindingSource;
            this.membershipsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.membershipsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.membershipsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.membershipsBindingNavigatorSaveItem});
            this.membershipsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.membershipsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.membershipsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.membershipsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.membershipsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.membershipsBindingNavigator.Name = "membershipsBindingNavigator";
            this.membershipsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.membershipsBindingNavigator.Size = new System.Drawing.Size(674, 25);
            this.membershipsBindingNavigator.TabIndex = 35;
            this.membershipsBindingNavigator.Tag = "ONLY_ADMIN";
            this.membershipsBindingNavigator.Text = "bindingNavigator1";
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
            // membershipsBindingNavigatorSaveItem
            // 
            this.membershipsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.membershipsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("membershipsBindingNavigatorSaveItem.Image")));
            this.membershipsBindingNavigatorSaveItem.Name = "membershipsBindingNavigatorSaveItem";
            this.membershipsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.membershipsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.membershipsBindingNavigatorSaveItem.Click += new System.EventHandler(this.membershipsBindingNavigatorSaveItem_Click);
            // 
            // membershipIDComboBox
            // 
            this.membershipIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membershipsBindingSource, "MembershipID", true));
            this.membershipIDComboBox.FormattingEnabled = true;
            this.membershipIDComboBox.Location = new System.Drawing.Point(137, 28);
            this.membershipIDComboBox.Name = "membershipIDComboBox";
            this.membershipIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.membershipIDComboBox.TabIndex = 36;
            // 
            // clientIDComboBox
            // 
            this.clientIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membershipsBindingSource, "ClientID", true));
            this.clientIDComboBox.DataSource = this.clientsBindingSource;
            this.clientIDComboBox.DisplayMember = "ClientID";
            this.clientIDComboBox.FormattingEnabled = true;
            this.clientIDComboBox.Location = new System.Drawing.Point(137, 55);
            this.clientIDComboBox.Name = "clientIDComboBox";
            this.clientIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.clientIDComboBox.TabIndex = 38;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.fitnessClubDataSet;
            // 
            // membershipTypeIDComboBox
            // 
            this.membershipTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membershipsBindingSource, "MembershipTypeID", true));
            this.membershipTypeIDComboBox.DataSource = this.membershipTypesBindingSource;
            this.membershipTypeIDComboBox.DisplayMember = "MembershipTypeID";
            this.membershipTypeIDComboBox.FormattingEnabled = true;
            this.membershipTypeIDComboBox.Location = new System.Drawing.Point(137, 82);
            this.membershipTypeIDComboBox.Name = "membershipTypeIDComboBox";
            this.membershipTypeIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.membershipTypeIDComboBox.TabIndex = 40;
            // 
            // membershipTypesBindingSource
            // 
            this.membershipTypesBindingSource.DataMember = "MembershipTypes";
            this.membershipTypesBindingSource.DataSource = this.fitnessClubDataSet;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.membershipsBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateDateTimePicker.Location = new System.Drawing.Point(137, 109);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateDateTimePicker.TabIndex = 42;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.membershipsBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateDateTimePicker.Location = new System.Drawing.Point(137, 135);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateDateTimePicker.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_client_address);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_client_date);
            this.groupBox1.Controls.Add(this.txt_client_number);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_client_surname);
            this.groupBox1.Controls.Add(this.txt_client_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(343, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 161);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "О клиенте";
            // 
            // txt_client_address
            // 
            this.txt_client_address.AccessibleName = "NONESTYLE";
            this.txt_client_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Address", true));
            this.txt_client_address.Location = new System.Drawing.Point(104, 101);
            this.txt_client_address.Name = "txt_client_address";
            this.txt_client_address.ReadOnly = true;
            this.txt_client_address.Size = new System.Drawing.Size(141, 20);
            this.txt_client_address.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Адрес -";
            // 
            // txt_client_date
            // 
            this.txt_client_date.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "BirthDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.txt_client_date.Location = new System.Drawing.Point(104, 51);
            this.txt_client_date.Name = "txt_client_date";
            this.txt_client_date.ReadOnly = true;
            this.txt_client_date.Size = new System.Drawing.Size(141, 20);
            this.txt_client_date.TabIndex = 6;
            // 
            // txt_client_number
            // 
            this.txt_client_number.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Phone", true));
            this.txt_client_number.Location = new System.Drawing.Point(104, 75);
            this.txt_client_number.Name = "txt_client_number";
            this.txt_client_number.ReadOnly = true;
            this.txt_client_number.Size = new System.Drawing.Size(141, 20);
            this.txt_client_number.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер телефона -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата рождения -";
            // 
            // txt_client_surname
            // 
            this.txt_client_surname.BackColor = System.Drawing.SystemColors.Control;
            this.txt_client_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_client_surname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "LastName", true));
            this.txt_client_surname.Location = new System.Drawing.Point(104, 25);
            this.txt_client_surname.Name = "txt_client_surname";
            this.txt_client_surname.ReadOnly = true;
            this.txt_client_surname.Size = new System.Drawing.Size(65, 20);
            this.txt_client_surname.TabIndex = 1;
            // 
            // txt_client_name
            // 
            this.txt_client_name.BackColor = System.Drawing.SystemColors.Control;
            this.txt_client_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_client_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "FirstName", true));
            this.txt_client_name.Location = new System.Drawing.Point(175, 25);
            this.txt_client_name.Name = "txt_client_name";
            this.txt_client_name.ReadOnly = true;
            this.txt_client_name.Size = new System.Drawing.Size(70, 20);
            this.txt_client_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИ -";
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 109);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "О абонементе";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membershipTypesBindingSource, "DurationMonths", true));
            this.textBox4.Location = new System.Drawing.Point(283, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(118, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Период -";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membershipTypesBindingSource, "Price", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.textBox3.Location = new System.Drawing.Point(481, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Стоимость -";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membershipTypesBindingSource, "Description", true));
            this.textBox2.Location = new System.Drawing.Point(101, 44);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(119, 40);
            this.textBox2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Описание -";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membershipTypesBindingSource, "MembershipTypeID", true));
            this.textBox1.Location = new System.Drawing.Point(101, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Наименование -";
            // 
            // membershipTypesTableAdapter
            // 
            this.membershipTypesTableAdapter.ClearBeforeFill = true;
            // 
            // btnSortWithForeign
            // 
            this.btnSortWithForeign.AccessibleName = "NONESTYLE";
            this.btnSortWithForeign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSortWithForeign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortWithForeign.Location = new System.Drawing.Point(231, 359);
            this.btnSortWithForeign.Name = "btnSortWithForeign";
            this.btnSortWithForeign.Size = new System.Drawing.Size(111, 23);
            this.btnSortWithForeign.TabIndex = 29;
            this.btnSortWithForeign.Text = "Сорт. с подстав.";
            this.btnSortWithForeign.UseVisualStyleBackColor = true;
            this.btnSortWithForeign.Click += new System.EventHandler(this.btnSortWithForeign_Click);
            // 
            // Membershis_Form
            // 
            this.AccessibleDescription = "Memberships";
            this.AccessibleName = "FORM_TRANSLATE";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(674, 393);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(membershipIDLabel);
            this.Controls.Add(this.membershipIDComboBox);
            this.Controls.Add(clientIDLabel);
            this.Controls.Add(this.clientIDComboBox);
            this.Controls.Add(membershipTypeIDLabel);
            this.Controls.Add(this.membershipTypeIDComboBox);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(this.membershipsBindingNavigator);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSortWithForeign);
            this.Controls.Add(this.btnSorting);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(622, 428);
            this.Name = "Membershis_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "SAVE_SIZE";
            this.Text = "Запись абонемента";
            this.Load += new System.EventHandler(this.Membershis_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipsBindingNavigator)).EndInit();
            this.membershipsBindingNavigator.ResumeLayout(false);
            this.membershipsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipTypesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSorting;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFirst;
        private FitnessClubDataSet fitnessClubDataSet;
        private System.Windows.Forms.BindingSource membershipsBindingSource;
        private FitnessClubDataSetTableAdapters.MembershipsTableAdapter membershipsTableAdapter;
        private FitnessClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator membershipsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton membershipsBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox membershipIDComboBox;
        private System.Windows.Forms.ComboBox clientIDComboBox;
        private System.Windows.Forms.ComboBox membershipTypeIDComboBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private FitnessClubDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.TextBox txt_client_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_client_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_client_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_client_date;
        private System.Windows.Forms.TextBox txt_client_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource membershipTypesBindingSource;
        private FitnessClubDataSetTableAdapters.MembershipTypesTableAdapter membershipTypesTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnSortWithForeign;
    }
}