namespace EmployeeCard
{
    partial class MainForm
    {
       
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.DepartmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTSMDep = new System.Windows.Forms.ToolStripMenuItem();
            this.editTSMDep = new System.Windows.Forms.ToolStripMenuItem();
            this.delTSMDep = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВСпискеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.emplMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTSMEmpl = new System.Windows.Forms.ToolStripMenuItem();
            this.editTSMEmpl = new System.Windows.Forms.ToolStripMenuItem();
            this.delTSMEmpl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportDBtoExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4PersonalData = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.addresTxt = new System.Windows.Forms.RichTextBox();
            this.fKEmployeePersonalDataEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKEmployeesDepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBDDataSet = new EmployeeCard.EmployeeBDDataSet();
            this.photoSeparatorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox5PersonalData = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.fotoPictureBox_2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.educationTxt = new System.Windows.Forms.RichTextBox();
            this.fKEmplWorkDataEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNameHidenField = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.WorkExpDisplayTxt = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cardField = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.departmentsCB = new System.Windows.Forms.ComboBox();
            this.groupBoxEmpl = new System.Windows.Forms.GroupBox();
            this.EmployeeGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addEmpl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editEmpl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.delEmpl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToWordBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.openCardBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.excelImportBtn = new System.Windows.Forms.ToolStripButton();
            this.employeeBDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter = new EmployeeCard.EmployeeBDDataSetTableAdapters.DepartmentsTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new EmployeeCard.EmployeeBDDataSetTableAdapters.EmployeesTableAdapter();
            this.employeePersonalDataTableAdapter = new EmployeeCard.EmployeeBDDataSetTableAdapters.EmployeePersonalDataTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emplWorkDataTableAdapter = new EmployeeCard.EmployeeBDDataSetTableAdapters.EmplWorkDataTableAdapter();
            this.expotToWordFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.exportToExcelDialog = new System.Windows.Forms.SaveFileDialog();
            this.exportToExcelBendingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exportToExcelDataSet = new EmployeeCard.exportToExcelDataSet();
            this.excelImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.xmlExportBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.xmlImportBtn = new System.Windows.Forms.ToolStripButton();
            this.xmlSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4PersonalData.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeePersonalDataEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeesDepartmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBDDataSet)).BeginInit();
            this.photoSeparatorTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5PersonalData.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox_2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmplWorkDataEmployeesBindingSource)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxEmpl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExcelBendingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExcelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.departamentsTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(1084, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1314, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // departamentsTSM
            // 
            this.departamentsTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DepartmentMenuItem,
            this.toolStripMenuItem1,
            this.emplMenuItem,
            this.toolStripMenuItem2,
            this.exportDBtoExcel});
            this.departamentsTSM.Name = "departamentsTSM";
            this.departamentsTSM.Size = new System.Drawing.Size(139, 20);
            this.departamentsTSM.Text = "Управление данными";
            // 
            // DepartmentMenuItem
            // 
            this.DepartmentMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTSMDep,
            this.editTSMDep,
            this.delTSMDep,
            this.удалитьВСпискеToolStripMenuItem});
            this.DepartmentMenuItem.Name = "DepartmentMenuItem";
            this.DepartmentMenuItem.Size = new System.Drawing.Size(176, 22);
            this.DepartmentMenuItem.Text = "Отделы";
            // 
            // addTSMDep
            // 
            this.addTSMDep.Name = "addTSMDep";
            this.addTSMDep.Size = new System.Drawing.Size(168, 22);
            this.addTSMDep.Text = "Добавить";
            this.addTSMDep.Click += new System.EventHandler(this.addTSMDep_Click);
            // 
            // editTSMDep
            // 
            this.editTSMDep.Name = "editTSMDep";
            this.editTSMDep.Size = new System.Drawing.Size(168, 22);
            this.editTSMDep.Text = "Изменить";
            this.editTSMDep.Click += new System.EventHandler(this.editTSMDep_Click);
            // 
            // delTSMDep
            // 
            this.delTSMDep.Name = "delTSMDep";
            this.delTSMDep.Size = new System.Drawing.Size(168, 22);
            this.delTSMDep.Text = "Удалить";
            this.delTSMDep.Click += new System.EventHandler(this.delTSMDep_Click);
            // 
            // удалитьВСпискеToolStripMenuItem
            // 
            this.удалитьВСпискеToolStripMenuItem.Name = "удалитьВСпискеToolStripMenuItem";
            this.удалитьВСпискеToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.удалитьВСпискеToolStripMenuItem.Text = "Удалить в списке";
            this.удалитьВСпискеToolStripMenuItem.Click += new System.EventHandler(this.удалитьВСпискеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 6);
            // 
            // emplMenuItem
            // 
            this.emplMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTSMEmpl,
            this.editTSMEmpl,
            this.delTSMEmpl});
            this.emplMenuItem.Name = "emplMenuItem";
            this.emplMenuItem.Size = new System.Drawing.Size(176, 22);
            this.emplMenuItem.Text = "Сотрудники";
            // 
            // addTSMEmpl
            // 
            this.addTSMEmpl.Name = "addTSMEmpl";
            this.addTSMEmpl.Size = new System.Drawing.Size(128, 22);
            this.addTSMEmpl.Text = "Добавить";
            this.addTSMEmpl.Click += new System.EventHandler(this.addTSMEmpl_Click);
            // 
            // editTSMEmpl
            // 
            this.editTSMEmpl.Name = "editTSMEmpl";
            this.editTSMEmpl.Size = new System.Drawing.Size(128, 22);
            this.editTSMEmpl.Text = "Изменить";
            this.editTSMEmpl.Click += new System.EventHandler(this.editTSMEmpl_Click);
            // 
            // delTSMEmpl
            // 
            this.delTSMEmpl.Name = "delTSMEmpl";
            this.delTSMEmpl.Size = new System.Drawing.Size(128, 22);
            this.delTSMEmpl.Text = "Удалить";
            this.delTSMEmpl.Click += new System.EventHandler(this.delTSMEmpl_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 6);
            // 
            // exportDBtoExcel
            // 
            this.exportDBtoExcel.Name = "exportDBtoExcel";
            this.exportDBtoExcel.Size = new System.Drawing.Size(176, 22);
            this.exportDBtoExcel.Text = "Экспорт БД в Excel";
            this.exportDBtoExcel.Click += new System.EventHandler(this.exportDBtoExcel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.8718F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.128204F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1314, 702);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(453, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 660);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные о сотруднике:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.MinimumSize = new System.Drawing.Size(722, 641);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(852, 641);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel4PersonalData);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(846, 314);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Персональные данные:";
            // 
            // tableLayoutPanel4PersonalData
            // 
            this.tableLayoutPanel4PersonalData.ColumnCount = 1;
            this.tableLayoutPanel4PersonalData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4PersonalData.Controls.Add(this.groupBox7, 0, 1);
            this.tableLayoutPanel4PersonalData.Controls.Add(this.photoSeparatorTableLayoutPanel, 0, 0);
            this.tableLayoutPanel4PersonalData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4PersonalData.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4PersonalData.Name = "tableLayoutPanel4PersonalData";
            this.tableLayoutPanel4PersonalData.RowCount = 2;
            this.tableLayoutPanel4PersonalData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel4PersonalData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4PersonalData.Size = new System.Drawing.Size(840, 295);
            this.tableLayoutPanel4PersonalData.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.addresTxt);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 163);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(834, 129);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Адрес регистрации:";
            // 
            // addresTxt
            // 
            this.addresTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addresTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmployeePersonalDataEmployeesBindingSource, "Address", true));
            this.addresTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addresTxt.Location = new System.Drawing.Point(3, 16);
            this.addresTxt.Name = "addresTxt";
            this.addresTxt.ReadOnly = true;
            this.addresTxt.Size = new System.Drawing.Size(828, 110);
            this.addresTxt.TabIndex = 0;
            this.addresTxt.Text = "";
            // 
            // fKEmployeePersonalDataEmployeesBindingSource
            // 
            this.fKEmployeePersonalDataEmployeesBindingSource.DataMember = "FK_EmployeePersonalData_Employees";
            this.fKEmployeePersonalDataEmployeesBindingSource.DataSource = this.fKEmployeesDepartmentsBindingSource;
            // 
            // fKEmployeesDepartmentsBindingSource
            // 
            this.fKEmployeesDepartmentsBindingSource.DataMember = "FK_Employees_Departments";
            this.fKEmployeesDepartmentsBindingSource.DataSource = this.departmentsBindingSource;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.employeeBDDataSet;
            // 
            // employeeBDDataSet
            // 
            this.employeeBDDataSet.DataSetName = "EmployeeBDDataSet";
            this.employeeBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // photoSeparatorTableLayoutPanel
            // 
            this.photoSeparatorTableLayoutPanel.ColumnCount = 2;
            this.photoSeparatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.photoSeparatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.photoSeparatorTableLayoutPanel.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.photoSeparatorTableLayoutPanel.Controls.Add(this.fotoPictureBox_2, 0, 0);
            this.photoSeparatorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photoSeparatorTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.photoSeparatorTableLayoutPanel.Name = "photoSeparatorTableLayoutPanel";
            this.photoSeparatorTableLayoutPanel.RowCount = 1;
            this.photoSeparatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.photoSeparatorTableLayoutPanel.Size = new System.Drawing.Size(834, 154);
            this.photoSeparatorTableLayoutPanel.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox6, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.groupBox5PersonalData, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(153, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(678, 148);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 103);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(672, 42);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Гражданство:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmployeePersonalDataEmployeesBindingSource, "Citizenship", true));
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(3, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(666, 20);
            this.textBox3.TabIndex = 0;
            // 
            // groupBox5PersonalData
            // 
            this.groupBox5PersonalData.Controls.Add(this.textBox1);
            this.groupBox5PersonalData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5PersonalData.Location = new System.Drawing.Point(3, 3);
            this.groupBox5PersonalData.Name = "groupBox5PersonalData";
            this.groupBox5PersonalData.Size = new System.Drawing.Size(672, 44);
            this.groupBox5PersonalData.TabIndex = 0;
            this.groupBox5PersonalData.TabStop = false;
            this.groupBox5PersonalData.Text = "Возраст:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmployeePersonalDataEmployeesBindingSource, "Age", true));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(666, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 53);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(672, 44);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Дата рождения:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmployeePersonalDataEmployeesBindingSource, "BirthDay", true));
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(666, 20);
            this.textBox2.TabIndex = 0;
            // 
            // fotoPictureBox_2
            // 
            this.fotoPictureBox_2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fotoPictureBox_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fotoPictureBox_2.Location = new System.Drawing.Point(3, 3);
            this.fotoPictureBox_2.Name = "fotoPictureBox_2";
            this.fotoPictureBox_2.Size = new System.Drawing.Size(144, 148);
            this.fotoPictureBox_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoPictureBox_2.TabIndex = 1;
            this.fotoPictureBox_2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 323);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(846, 315);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Рабочие данные:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox10, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox9, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox11, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(840, 296);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.educationTxt);
            this.groupBox10.Controls.Add(this.imageNameHidenField);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Enabled = false;
            this.groupBox10.Location = new System.Drawing.Point(3, 103);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(834, 140);
            this.groupBox10.TabIndex = 4;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Образование:";
            // 
            // educationTxt
            // 
            this.educationTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.educationTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplWorkDataEmployeesBindingSource, "Education", true));
            this.educationTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.educationTxt.Location = new System.Drawing.Point(3, 16);
            this.educationTxt.Name = "educationTxt";
            this.educationTxt.ReadOnly = true;
            this.educationTxt.Size = new System.Drawing.Size(828, 121);
            this.educationTxt.TabIndex = 0;
            this.educationTxt.Text = "";
            // 
            // fKEmplWorkDataEmployeesBindingSource
            // 
            this.fKEmplWorkDataEmployeesBindingSource.DataMember = "FK_EmplWorkData_Employees";
            this.fKEmplWorkDataEmployeesBindingSource.DataSource = this.fKEmployeesDepartmentsBindingSource;
            // 
            // imageNameHidenField
            // 
            this.imageNameHidenField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmployeePersonalDataEmployeesBindingSource, "PhotoFileName", true));
            this.imageNameHidenField.Location = new System.Drawing.Point(7, 20);
            this.imageNameHidenField.Name = "imageNameHidenField";
            this.imageNameHidenField.Size = new System.Drawing.Size(1, 20);
            this.imageNameHidenField.TabIndex = 1;
            this.imageNameHidenField.TextChanged += new System.EventHandler(this.imageNameHidenField_TextChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.WorkExpDisplayTxt);
            this.groupBox9.Controls.Add(this.textBox5);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 53);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(834, 44);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Опыт работы:";
            // 
            // WorkExpDisplayTxt
            // 
            this.WorkExpDisplayTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.WorkExpDisplayTxt.Location = new System.Drawing.Point(120, 16);
            this.WorkExpDisplayTxt.Name = "WorkExpDisplayTxt";
            this.WorkExpDisplayTxt.ReadOnly = true;
            this.WorkExpDisplayTxt.Size = new System.Drawing.Size(708, 20);
            this.WorkExpDisplayTxt.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplWorkDataEmployeesBindingSource, "WorkExperience", true));
            this.textBox5.Location = new System.Drawing.Point(3, 16);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(111, 20);
            this.textBox5.TabIndex = 0;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox4);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(834, 44);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Должность:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplWorkDataEmployeesBindingSource, "Post", true));
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(3, 16);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(828, 20);
            this.textBox4.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cardField);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 249);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(834, 44);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Карточка сотрудника";
            // 
            // cardField
            // 
            this.cardField.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cardField.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKEmplWorkDataEmployeesBindingSource, "WorkCard", true));
            this.cardField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardField.Location = new System.Drawing.Point(3, 16);
            this.cardField.Name = "cardField";
            this.cardField.ReadOnly = true;
            this.cardField.Size = new System.Drawing.Size(828, 20);
            this.cardField.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxEmpl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(444, 660);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.departmentsCB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отделы:";
            // 
            // departmentsCB
            // 
            this.departmentsCB.DataSource = this.departmentsBindingSource;
            this.departmentsCB.DisplayMember = "Title";
            this.departmentsCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentsCB.FormattingEnabled = true;
            this.departmentsCB.Location = new System.Drawing.Point(3, 16);
            this.departmentsCB.Name = "departmentsCB";
            this.departmentsCB.Size = new System.Drawing.Size(432, 21);
            this.departmentsCB.TabIndex = 1;
            this.departmentsCB.ValueMember = "Id";
            this.departmentsCB.SelectedIndexChanged += new System.EventHandler(this.departmentsCB_SelectedIndexChanged);
            // 
            // groupBoxEmpl
            // 
            this.groupBoxEmpl.Controls.Add(this.EmployeeGV);
            this.groupBoxEmpl.Controls.Add(this.photoPictureBox);
            this.groupBoxEmpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEmpl.Location = new System.Drawing.Point(3, 53);
            this.groupBoxEmpl.Name = "groupBoxEmpl";
            this.groupBoxEmpl.Size = new System.Drawing.Size(438, 554);
            this.groupBoxEmpl.TabIndex = 1;
            this.groupBoxEmpl.TabStop = false;
            this.groupBoxEmpl.Text = "Сотрудники:";
            // 
            // EmployeeGV
            // 
            this.EmployeeGV.AllowUserToAddRows = false;
            this.EmployeeGV.AllowUserToDeleteRows = false;
            this.EmployeeGV.AutoGenerateColumns = false;
            this.EmployeeGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmployeeGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.departmentIdDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.midleNameDataGridViewTextBoxColumn});
            this.EmployeeGV.DataSource = this.fKEmployeesDepartmentsBindingSource;
            this.EmployeeGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeGV.Location = new System.Drawing.Point(3, 16);
            this.EmployeeGV.Name = "EmployeeGV";
            this.EmployeeGV.ReadOnly = true;
            this.EmployeeGV.RowHeadersVisible = false;
            this.EmployeeGV.RowHeadersWidth = 51;
            this.EmployeeGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeGV.Size = new System.Drawing.Size(432, 535);
            this.EmployeeGV.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.HeaderText = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            this.departmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentIdDataGridViewTextBoxColumn.Visible = false;
            this.departmentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // midleNameDataGridViewTextBoxColumn
            // 
            this.midleNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.midleNameDataGridViewTextBoxColumn.DataPropertyName = "MidleName";
            this.midleNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.midleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.midleNameDataGridViewTextBoxColumn.Name = "midleNameDataGridViewTextBoxColumn";
            this.midleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.fKEmployeePersonalDataEmployeesBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(24546, 107);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(54, 47);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 1;
            this.photoPictureBox.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmpl,
            this.toolStripSeparator1,
            this.editEmpl,
            this.toolStripSeparator2,
            this.delEmpl,
            this.toolStripSeparator3,
            this.exportToWordBtn,
            this.toolStripSeparator4,
            this.exportToExcel,
            this.toolStripSeparator5,
            this.openCardBtn,
            this.toolStripSeparator6,
            this.excelImportBtn,
            this.toolStripSeparator7,
            this.xmlExportBtn,
            this.toolStripSeparator8,
            this.xmlImportBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 610);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(444, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addEmpl
            // 
            this.addEmpl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addEmpl.Image = ((System.Drawing.Image)(resources.GetObject("addEmpl.Image")));
            this.addEmpl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addEmpl.Name = "addEmpl";
            this.addEmpl.Size = new System.Drawing.Size(63, 22);
            this.addEmpl.Text = "Добавить";
            this.addEmpl.Click += new System.EventHandler(this.addEmpl_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // editEmpl
            // 
            this.editEmpl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editEmpl.Image = ((System.Drawing.Image)(resources.GetObject("editEmpl.Image")));
            this.editEmpl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editEmpl.Name = "editEmpl";
            this.editEmpl.Size = new System.Drawing.Size(65, 22);
            this.editEmpl.Text = "Изменить";
            this.editEmpl.Click += new System.EventHandler(this.editEmpl_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // delEmpl
            // 
            this.delEmpl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.delEmpl.Image = ((System.Drawing.Image)(resources.GetObject("delEmpl.Image")));
            this.delEmpl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delEmpl.Name = "delEmpl";
            this.delEmpl.Size = new System.Drawing.Size(55, 22);
            this.delEmpl.Text = "Удалить";
            this.delEmpl.Click += new System.EventHandler(this.delEmpl_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // exportToWordBtn
            // 
            this.exportToWordBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exportToWordBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportToWordBtn.Image")));
            this.exportToWordBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToWordBtn.Name = "exportToWordBtn";
            this.exportToWordBtn.Size = new System.Drawing.Size(97, 22);
            this.exportToWordBtn.Text = "Экспорт в Word";
            this.exportToWordBtn.Click += new System.EventHandler(this.exportToWordBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // exportToExcel
            // 
            this.exportToExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("exportToExcel.Image")));
            this.exportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToExcel.Name = "exportToExcel";
            this.exportToExcel.Size = new System.Drawing.Size(95, 22);
            this.exportToExcel.Text = "Экспорт в Excel";
            this.exportToExcel.Click += new System.EventHandler(this.exportToExcel_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // openCardBtn
            // 
            this.openCardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openCardBtn.Image = ((System.Drawing.Image)(resources.GetObject("openCardBtn.Image")));
            this.openCardBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openCardBtn.Name = "openCardBtn";
            this.openCardBtn.Size = new System.Drawing.Size(177, 19);
            this.openCardBtn.Text = "Открыть карточку сотрудника";
            this.openCardBtn.Click += new System.EventHandler(this.openCardBtn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 6);
            // 
            // excelImportBtn
            // 
            this.excelImportBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.excelImportBtn.Image = ((System.Drawing.Image)(resources.GetObject("excelImportBtn.Image")));
            this.excelImportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.excelImportBtn.Name = "excelImportBtn";
            this.excelImportBtn.Size = new System.Drawing.Size(100, 19);
            this.excelImportBtn.Text = "Импорт из Excel";
            this.excelImportBtn.Click += new System.EventHandler(this.excelImportBtn_Click);
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employeeBDDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeePersonalDataTableAdapter
            // 
            this.employeePersonalDataTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.fKEmplWorkDataEmployeesBindingSource;
            // 
            // emplWorkDataTableAdapter
            // 
            this.emplWorkDataTableAdapter.ClearBeforeFill = true;
            // 
            // expotToWordFileDialog
            // 
            this.expotToWordFileDialog.Filter = "Word files | *.docx";
            // 
            // exportToExcelDialog
            // 
            this.exportToExcelDialog.Filter = "Excel files | *.xlsx";
            // 
            // exportToExcelBendingSource
            // 
            this.exportToExcelBendingSource.DataSource = this.exportToExcelDataSet;
            this.exportToExcelBendingSource.Position = 0;
            // 
            // exportToExcelDataSet
            // 
            this.exportToExcelDataSet.DataSetName = "exportToExcelDataSet";
            this.exportToExcelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // excelImportFileDialog
            // 
            this.excelImportFileDialog.Filter = "(Excel files)|*.xlsx";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 6);
            // 
            // xmlExportBtn
            // 
            this.xmlExportBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.xmlExportBtn.Image = ((System.Drawing.Image)(resources.GetObject("xmlExportBtn.Image")));
            this.xmlExportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.xmlExportBtn.Name = "xmlExportBtn";
            this.xmlExportBtn.Size = new System.Drawing.Size(92, 19);
            this.xmlExportBtn.Text = "Экспорт в XML";
            this.xmlExportBtn.Click += new System.EventHandler(this.xmlExportBtn_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 6);
            // 
            // xmlImportBtn
            // 
            this.xmlImportBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.xmlImportBtn.Image = ((System.Drawing.Image)(resources.GetObject("xmlImportBtn.Image")));
            this.xmlImportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.xmlImportBtn.Name = "xmlImportBtn";
            this.xmlImportBtn.Size = new System.Drawing.Size(97, 19);
            this.xmlImportBtn.Text = "Импорт из XML";
            this.xmlImportBtn.Click += new System.EventHandler(this.xmlImportBtn_Click);
            // 
            // xmlSaveFileDialog
            // 
            this.xmlSaveFileDialog.Filter = "(XML files)|*.xml";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 726);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1329, 764);
            this.Name = "MainForm";
            this.Text = "Карточка сотрудника";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4PersonalData.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeePersonalDataEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeesDepartmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBDDataSet)).EndInit();
            this.photoSeparatorTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5PersonalData.ResumeLayout(false);
            this.groupBox5PersonalData.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox_2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmplWorkDataEmployeesBindingSource)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxEmpl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExcelBendingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToExcelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentsTSM;
        private System.Windows.Forms.ToolStripMenuItem DepartmentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emplMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTSMEmpl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox departmentsCB;
        private System.Windows.Forms.GroupBox groupBoxEmpl;
        private System.Windows.Forms.DataGridView EmployeeGV;
        private System.Windows.Forms.BindingSource employeeBDBindingSource;
        private EmployeeBDDataSet employeeBDDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private EmployeeBDDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeeBDDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource fKEmployeesDepartmentsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4PersonalData;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox addresTxt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox5PersonalData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RichTextBox educationTxt;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addEmpl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton editEmpl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton delEmpl;
        private System.Windows.Forms.ToolStripMenuItem addTSMDep;
        private System.Windows.Forms.ToolStripMenuItem editTSMDep;
        private System.Windows.Forms.ToolStripMenuItem delTSMDep;
        private System.Windows.Forms.ToolStripMenuItem editTSMEmpl;
        private System.Windows.Forms.ToolStripMenuItem delTSMEmpl;
        private System.Windows.Forms.BindingSource fKEmployeePersonalDataEmployeesBindingSource;
        private EmployeeBDDataSetTableAdapters.EmployeePersonalDataTableAdapter employeePersonalDataTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource fKEmplWorkDataEmployeesBindingSource;
        private EmployeeBDDataSetTableAdapters.EmplWorkDataTableAdapter emplWorkDataTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem удалитьВСпискеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox WorkExpDisplayTxt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton exportToWordBtn;
        private System.Windows.Forms.SaveFileDialog expotToWordFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exportDBtoExcel;
        private System.Windows.Forms.SaveFileDialog exportToExcelDialog;
        private System.Windows.Forms.BindingSource exportToExcelBendingSource;
        private exportToExcelDataSet exportToExcelDataSet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton exportToExcel;
        private System.Windows.Forms.TableLayoutPanel photoSeparatorTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.PictureBox fotoPictureBox_2;
        private System.Windows.Forms.TextBox imageNameHidenField;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox cardField;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton openCardBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton excelImportBtn;
        private System.Windows.Forms.OpenFileDialog excelImportFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton xmlExportBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton xmlImportBtn;
        private System.Windows.Forms.SaveFileDialog xmlSaveFileDialog;
    }
}

