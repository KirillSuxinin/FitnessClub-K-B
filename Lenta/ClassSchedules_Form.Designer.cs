namespace FitnessClub.Lenta
{
    partial class ClassSchedules_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassSchedules_Form));
            System.Windows.Forms.Label classScheduleIDLabel;
            System.Windows.Forms.Label classIDLabel;
            System.Windows.Forms.Label scheduledDateLabel;
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
            this.classSchedulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classSchedulesTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.ClassSchedulesTableAdapter();
            this.tableAdapterManager = new FitnessClub.FitnessClubDataSetTableAdapters.TableAdapterManager();
            this.classSchedulesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.classSchedulesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.classScheduleIDComboBox = new System.Windows.Forms.ComboBox();
            this.classIDComboBox = new System.Windows.Forms.ComboBox();
            this.scheduledDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            classScheduleIDLabel = new System.Windows.Forms.Label();
            classIDLabel = new System.Windows.Forms.Label();
            scheduledDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSchedulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSchedulesBindingNavigator)).BeginInit();
            this.classSchedulesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_last
            // 
            this.btn_last.AccessibleName = "NONESTYLE";
            this.btn_last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_last.Location = new System.Drawing.Point(504, 160);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(92, 23);
            this.btn_last.TabIndex = 40;
            this.btn_last.Text = "Посл. запись";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.AccessibleName = "NONESTYLE";
            this.btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Location = new System.Drawing.Point(406, 160);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(92, 23);
            this.btn_Next.TabIndex = 41;
            this.btn_Next.Text = "След. запись";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.AccessibleName = "NONESTYLE";
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(109, 160);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(92, 23);
            this.btnPrev.TabIndex = 42;
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
            this.btnCancel.Location = new System.Drawing.Point(234, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 23);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Отменить изменения";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSorting
            // 
            this.btnSorting.AccessibleName = "NONESTYLE";
            this.btnSorting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSorting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorting.Location = new System.Drawing.Point(109, 206);
            this.btnSorting.Name = "btnSorting";
            this.btnSorting.Size = new System.Drawing.Size(111, 23);
            this.btnSorting.TabIndex = 44;
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
            this.btnDelete.Location = new System.Drawing.Point(308, 205);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 23);
            this.btnDelete.TabIndex = 45;
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
            this.btnAdd.Location = new System.Drawing.Point(406, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 46;
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
            this.btnSave.Location = new System.Drawing.Point(504, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 23);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "NONESTYLE";
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(11, 206);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 23);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.AccessibleName = "NONESTYLE";
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(11, 160);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(92, 23);
            this.btnFirst.TabIndex = 49;
            this.btnFirst.Text = "Перв. запись";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // fitnessClubDataSet
            // 
            this.fitnessClubDataSet.DataSetName = "FitnessClubDataSet";
            this.fitnessClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classSchedulesBindingSource
            // 
            this.classSchedulesBindingSource.DataMember = "ClassSchedules";
            this.classSchedulesBindingSource.DataSource = this.fitnessClubDataSet;
            // 
            // classSchedulesTableAdapter
            // 
            this.classSchedulesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassEquipmentTableAdapter = null;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.ClassSchedulesTableAdapter = this.classSchedulesTableAdapter;
            this.tableAdapterManager.ClientClassRegistrationsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.ImagesTableAdapter = null;
            this.tableAdapterManager.MembershipsTableAdapter = null;
            this.tableAdapterManager.MembershipTypesTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.TrainersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FitnessClub.FitnessClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // classSchedulesBindingNavigator
            // 
            this.classSchedulesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.classSchedulesBindingNavigator.BackColor = System.Drawing.Color.Red;
            this.classSchedulesBindingNavigator.BindingSource = this.classSchedulesBindingSource;
            this.classSchedulesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.classSchedulesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.classSchedulesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.classSchedulesBindingNavigatorSaveItem});
            this.classSchedulesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.classSchedulesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.classSchedulesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.classSchedulesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.classSchedulesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.classSchedulesBindingNavigator.Name = "classSchedulesBindingNavigator";
            this.classSchedulesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.classSchedulesBindingNavigator.Size = new System.Drawing.Size(610, 25);
            this.classSchedulesBindingNavigator.TabIndex = 50;
            this.classSchedulesBindingNavigator.Tag = "ONLY_ADMIN";
            this.classSchedulesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // classSchedulesBindingNavigatorSaveItem
            // 
            this.classSchedulesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.classSchedulesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("classSchedulesBindingNavigatorSaveItem.Image")));
            this.classSchedulesBindingNavigatorSaveItem.Name = "classSchedulesBindingNavigatorSaveItem";
            this.classSchedulesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.classSchedulesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.classSchedulesBindingNavigatorSaveItem.Click += new System.EventHandler(this.classSchedulesBindingNavigatorSaveItem_Click);
            // 
            // classScheduleIDLabel
            // 
            classScheduleIDLabel.AutoSize = true;
            classScheduleIDLabel.Location = new System.Drawing.Point(6, 40);
            classScheduleIDLabel.Name = "classScheduleIDLabel";
            classScheduleIDLabel.Size = new System.Drawing.Size(97, 13);
            classScheduleIDLabel.TabIndex = 50;
            classScheduleIDLabel.Text = "Class Schedule ID:";
            // 
            // classScheduleIDComboBox
            // 
            this.classScheduleIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classSchedulesBindingSource, "ClassScheduleID", true));
            this.classScheduleIDComboBox.FormattingEnabled = true;
            this.classScheduleIDComboBox.Location = new System.Drawing.Point(125, 37);
            this.classScheduleIDComboBox.Name = "classScheduleIDComboBox";
            this.classScheduleIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.classScheduleIDComboBox.TabIndex = 51;
            // 
            // classIDLabel
            // 
            classIDLabel.AutoSize = true;
            classIDLabel.Location = new System.Drawing.Point(6, 67);
            classIDLabel.Name = "classIDLabel";
            classIDLabel.Size = new System.Drawing.Size(49, 13);
            classIDLabel.TabIndex = 52;
            classIDLabel.Text = "Class ID:";
            // 
            // classIDComboBox
            // 
            this.classIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classSchedulesBindingSource, "ClassID", true));
            this.classIDComboBox.FormattingEnabled = true;
            this.classIDComboBox.Location = new System.Drawing.Point(125, 64);
            this.classIDComboBox.Name = "classIDComboBox";
            this.classIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.classIDComboBox.TabIndex = 53;
            // 
            // scheduledDateLabel
            // 
            scheduledDateLabel.AutoSize = true;
            scheduledDateLabel.Location = new System.Drawing.Point(6, 95);
            scheduledDateLabel.Name = "scheduledDateLabel";
            scheduledDateLabel.Size = new System.Drawing.Size(87, 13);
            scheduledDateLabel.TabIndex = 54;
            scheduledDateLabel.Text = "Scheduled Date:";
            // 
            // scheduledDateDateTimePicker
            // 
            this.scheduledDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.classSchedulesBindingSource, "ScheduledDate", true));
            this.scheduledDateDateTimePicker.Location = new System.Drawing.Point(125, 91);
            this.scheduledDateDateTimePicker.Name = "scheduledDateDateTimePicker";
            this.scheduledDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.scheduledDateDateTimePicker.TabIndex = 55;
            // 
            // ClassSchedules_Form
            // 
            this.AccessibleDescription = "ClassSchedules";
            this.AccessibleName = "FORM_TRANSLATE";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(610, 239);
            this.Controls.Add(classScheduleIDLabel);
            this.Controls.Add(this.classScheduleIDComboBox);
            this.Controls.Add(classIDLabel);
            this.Controls.Add(this.classIDComboBox);
            this.Controls.Add(scheduledDateLabel);
            this.Controls.Add(this.scheduledDateDateTimePicker);
            this.Controls.Add(this.classSchedulesBindingNavigator);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClassSchedules_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "SAVE_SIZE";
            this.Text = "Расписание занятий";
            this.Load += new System.EventHandler(this.ClassSchedules_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSchedulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSchedulesBindingNavigator)).EndInit();
            this.classSchedulesBindingNavigator.ResumeLayout(false);
            this.classSchedulesBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.BindingSource classSchedulesBindingSource;
        private FitnessClubDataSetTableAdapters.ClassSchedulesTableAdapter classSchedulesTableAdapter;
        private FitnessClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator classSchedulesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton classSchedulesBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox classScheduleIDComboBox;
        private System.Windows.Forms.ComboBox classIDComboBox;
        private System.Windows.Forms.DateTimePicker scheduledDateDateTimePicker;
    }
}