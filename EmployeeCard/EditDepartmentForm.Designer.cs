namespace EmployeeCard
{
    partial class EditDepartmentForm
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
            this.labelDepName = new System.Windows.Forms.Label();
            this.textBoxDepName = new System.Windows.Forms.TextBox();
            this.buttonSaveDep = new System.Windows.Forms.Button();
            this.buttonCancelDep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDepName
            // 
            this.labelDepName.AutoSize = true;
            this.labelDepName.Location = new System.Drawing.Point(9, 23);
            this.labelDepName.Name = "labelDepName";
            this.labelDepName.Size = new System.Drawing.Size(98, 13);
            this.labelDepName.TabIndex = 0;
            this.labelDepName.Text = "Название отдела:";
            // 
            // textBoxDepName
            // 
            this.textBoxDepName.Location = new System.Drawing.Point(12, 39);
            this.textBoxDepName.Name = "textBoxDepName";
            this.textBoxDepName.Size = new System.Drawing.Size(360, 20);
            this.textBoxDepName.TabIndex = 1;
            // 
            // buttonSaveDep
            // 
            this.buttonSaveDep.Location = new System.Drawing.Point(12, 81);
            this.buttonSaveDep.Name = "buttonSaveDep";
            this.buttonSaveDep.Size = new System.Drawing.Size(161, 23);
            this.buttonSaveDep.TabIndex = 2;
            this.buttonSaveDep.Text = "Сохранить";
            this.buttonSaveDep.UseVisualStyleBackColor = true;
            this.buttonSaveDep.Click += new System.EventHandler(this.buttonSaveDep_Click);
            // 
            // buttonCancelDep
            // 
            this.buttonCancelDep.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelDep.Location = new System.Drawing.Point(211, 81);
            this.buttonCancelDep.Name = "buttonCancelDep";
            this.buttonCancelDep.Size = new System.Drawing.Size(161, 23);
            this.buttonCancelDep.TabIndex = 3;
            this.buttonCancelDep.Text = "Отмена";
            this.buttonCancelDep.UseVisualStyleBackColor = true;
            // 
            // EditDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 116);
            this.Controls.Add(this.buttonCancelDep);
            this.Controls.Add(this.buttonSaveDep);
            this.Controls.Add(this.textBoxDepName);
            this.Controls.Add(this.labelDepName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(400, 155);
            this.MinimumSize = new System.Drawing.Size(400, 155);
            this.Name = "EditDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Отдел";
            this.Load += new System.EventHandler(this.EditDepartmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDepName;
        private System.Windows.Forms.TextBox textBoxDepName;
        private System.Windows.Forms.Button buttonSaveDep;
        private System.Windows.Forms.Button buttonCancelDep;
    }
}