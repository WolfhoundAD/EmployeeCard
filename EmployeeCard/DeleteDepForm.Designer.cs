namespace EmployeeCard
{
    partial class DeleteDepForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.departmentsCB = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBDDataSet = new EmployeeCard.EmployeeBDDataSet();
            this.deleteDepButton = new System.Windows.Forms.Button();
            this.cancelDepBatton = new System.Windows.Forms.Button();
            this.departmentsTableAdapter = new EmployeeCard.EmployeeBDDataSetTableAdapters.DepartmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отдел:";
            // 
            // departmentsCB
            // 
            this.departmentsCB.DataSource = this.departmentsBindingSource;
            this.departmentsCB.DisplayMember = "Title";
            this.departmentsCB.FormattingEnabled = true;
            this.departmentsCB.Location = new System.Drawing.Point(12, 29);
            this.departmentsCB.Name = "departmentsCB";
            this.departmentsCB.Size = new System.Drawing.Size(350, 21);
            this.departmentsCB.TabIndex = 1;
            this.departmentsCB.ValueMember = "Id";
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
            // deleteDepButton
            // 
            this.deleteDepButton.Location = new System.Drawing.Point(12, 67);
            this.deleteDepButton.Name = "deleteDepButton";
            this.deleteDepButton.Size = new System.Drawing.Size(350, 23);
            this.deleteDepButton.TabIndex = 2;
            this.deleteDepButton.Text = "Удалить";
            this.deleteDepButton.UseVisualStyleBackColor = true;
            this.deleteDepButton.Click += new System.EventHandler(this.deleteDepButton_Click);
            // 
            // cancelDepBatton
            // 
            this.cancelDepBatton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelDepBatton.Location = new System.Drawing.Point(125, 106);
            this.cancelDepBatton.Name = "cancelDepBatton";
            this.cancelDepBatton.Size = new System.Drawing.Size(121, 23);
            this.cancelDepBatton.TabIndex = 3;
            this.cancelDepBatton.Text = "Закрыть";
            this.cancelDepBatton.UseVisualStyleBackColor = true;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteDepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 141);
            this.Controls.Add(this.cancelDepBatton);
            this.Controls.Add(this.deleteDepButton);
            this.Controls.Add(this.departmentsCB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(390, 180);
            this.MinimumSize = new System.Drawing.Size(390, 180);
            this.Name = "DeleteDepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удалить отдел";
            this.Load += new System.EventHandler(this.DeleteDepForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departmentsCB;
        private System.Windows.Forms.Button deleteDepButton;
        private System.Windows.Forms.Button cancelDepBatton;
        private EmployeeBDDataSet employeeBDDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private EmployeeBDDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
    }
}