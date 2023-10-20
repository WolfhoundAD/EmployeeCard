namespace EmployeeCard
{
    partial class EditEmployeeForm
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
            this.labelDep = new System.Windows.Forms.Label();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBDDataSet = new EmployeeCard.EmployeeBDDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxAddres = new System.Windows.Forms.RichTextBox();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editEmployeeDataSet = new EmployeeCard.EditEmployeeDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCitizenship = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerWorkExperience = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBoxEducation = new System.Windows.Forms.RichTextBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.departmentsTableAdapter = new EmployeeCard.EmployeeBDDataSetTableAdapters.DepartmentsTableAdapter();
            this.dataTable1TableAdapter = new EmployeeCard.EditEmployeeDataSetTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBDDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(12, 9);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(41, 13);
            this.labelDep.TabIndex = 0;
            this.labelDep.Text = "Отдел:";
            this.labelDep.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.DataSource = this.departmentsBindingSource;
            this.comboBoxDep.DisplayMember = "Title";
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.Location = new System.Drawing.Point(12, 26);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(400, 21);
            this.comboBoxDep.TabIndex = 1;
            this.comboBoxDep.ValueMember = "Id";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxAddres);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxCitizenship);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePickerBirthDay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxMiddleName);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 385);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Персональные данные:";
            // 
            // richTextBoxAddres
            // 
            this.richTextBoxAddres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editEmployeeDataSet, "DataTable1.Address", true));
            this.richTextBoxAddres.Location = new System.Drawing.Point(6, 248);
            this.richTextBoxAddres.Name = "richTextBoxAddres";
            this.richTextBoxAddres.Size = new System.Drawing.Size(388, 131);
            this.richTextBoxAddres.TabIndex = 12;
            this.richTextBoxAddres.Text = "";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.editEmployeeDataSet;
            // 
            // editEmployeeDataSet
            // 
            this.editEmployeeDataSet.DataSetName = "EditEmployeeDataSet";
            this.editEmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Адрес регистрации:";
            // 
            // textBoxCitizenship
            // 
            this.textBoxCitizenship.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editEmployeeDataSet, "DataTable1.Citizenship", true));
            this.textBoxCitizenship.Location = new System.Drawing.Point(6, 205);
            this.textBoxCitizenship.Name = "textBoxCitizenship";
            this.textBoxCitizenship.Size = new System.Drawing.Size(388, 20);
            this.textBoxCitizenship.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Гражданство:";
            // 
            // dateTimePickerBirthDay
            // 
            this.dateTimePickerBirthDay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.editEmployeeDataSet, "DataTable1.BirthDay", true));
            this.dateTimePickerBirthDay.Location = new System.Drawing.Point(6, 162);
            this.dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            this.dateTimePickerBirthDay.Size = new System.Drawing.Size(388, 20);
            this.dateTimePickerBirthDay.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дата рождения:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editEmployeeDataSet, "DataTable1.MidleName", true));
            this.textBoxMiddleName.Location = new System.Drawing.Point(6, 118);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(388, 20);
            this.textBoxMiddleName.TabIndex = 5;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editEmployeeDataSet, "DataTable1.FirstName", true));
            this.textBoxFirstName.Location = new System.Drawing.Point(6, 78);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(388, 20);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editEmployeeDataSet, "DataTable1.LastName", true));
            this.textBoxLastName.Location = new System.Drawing.Point(6, 37);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(388, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Отчество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фамилия:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerWorkExperience);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.richTextBoxEducation);
            this.groupBox2.Controls.Add(this.textBoxPost);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(422, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 385);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Рабочие данные:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dateTimePickerWorkExperience
            // 
            this.dateTimePickerWorkExperience.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.editEmployeeDataSet, "DataTable1.WorkExperience", true));
            this.dateTimePickerWorkExperience.Location = new System.Drawing.Point(6, 222);
            this.dateTimePickerWorkExperience.Name = "dateTimePickerWorkExperience";
            this.dateTimePickerWorkExperience.Size = new System.Drawing.Size(388, 20);
            this.dateTimePickerWorkExperience.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Дата начала карьеры:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Данные об образовании:";
            // 
            // richTextBoxEducation
            // 
            this.richTextBoxEducation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editEmployeeDataSet, "DataTable1.Education", true));
            this.richTextBoxEducation.Location = new System.Drawing.Point(6, 96);
            this.richTextBoxEducation.Name = "richTextBoxEducation";
            this.richTextBoxEducation.Size = new System.Drawing.Size(388, 96);
            this.richTextBoxEducation.TabIndex = 2;
            this.richTextBoxEducation.Text = "";
            // 
            // textBoxPost
            // 
            this.textBoxPost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editEmployeeDataSet, "DataTable1.Post", true));
            this.textBoxPost.Location = new System.Drawing.Point(6, 37);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(388, 20);
            this.textBoxPost.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Должность:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(18, 456);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(145, 25);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(671, 454);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(145, 25);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 491);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxDep);
            this.Controls.Add(this.labelDep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(850, 530);
            this.MinimumSize = new System.Drawing.Size(850, 530);
            this.Name = "EditEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.EditEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBDDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editEmployeeDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.ComboBox comboBoxDep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCitizenship;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxAddres;
        private System.Windows.Forms.DateTimePicker dateTimePickerWorkExperience;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBoxEducation;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private EmployeeBDDataSet employeeBDDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private EmployeeBDDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private EditEmployeeDataSet editEmployeeDataSet;
        private EditEmployeeDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}