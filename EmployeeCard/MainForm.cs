using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using EmployeeCard.Utils;

namespace EmployeeCard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {

            
               RefreshData();
               addresTxt.ReadOnly = true;
               educationTxt.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void RefreshData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeBDDataSet.EmplWorkData". При необходимости она может быть перемещена или удалена.
            this.emplWorkDataTableAdapter.Fill(this.employeeBDDataSet.EmplWorkData);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeBDDataSet.EmployeePersonalData". При необходимости она может быть перемещена или удалена.
            this.employeePersonalDataTableAdapter.Fill(this.employeeBDDataSet.EmployeePersonalData);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeBDDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.employeeBDDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeBDDataSet.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.employeeBDDataSet.Departments);
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void addTSMDep_Click(object sender, EventArgs e)
        {
            try
            {
                if (new EditDepartmentForm().ShowDialog() == DialogResult.OK)
                {
                    this.departmentsTableAdapter.Fill(this.employeeBDDataSet.Departments);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void editTSMDep_Click(object sender, EventArgs e)
        {
            try
            {
                if (departmentsCB.Items.Count == 0)
            {
                MessageBox.Show("Отсутствует выбранный отдел");
                return;
            }
            var id = 0;
            if (int.TryParse(departmentsCB.SelectedValue.ToString(), out id)
                && new EditDepartmentForm(true, id).ShowDialog() == DialogResult.OK)
            {
                   this.departmentsTableAdapter.Fill(this.employeeBDDataSet.Departments);
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        
        private void editDepMenuItem_Click(object sender, EventArgs e)
        {
            new EditDepartmentForm(true, 1).ShowDialog();
        }
        
        private void delTSMDep_Click(object sender, EventArgs e)
        {
            try
            {

            
            if (departmentsCB.Items.Count == 0)
            {
                MessageBox.Show("Отсутствует выбранный отдел!");
                return;
            }
            var id = 0;
           
            if (int.TryParse(departmentsCB.SelectedValue.ToString(), out id)
                && MessageBox.Show($"Вы действительно хотите удалить отдел ({departmentsCB.Text})?",
                            "Удалить выбранный отдел", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DBHelper.DeleteEntry(Constants.TableNames.DepartmentsTableName, id);
                this.departmentsTableAdapter.Fill(this.employeeBDDataSet.Departments);
            }
            
            if (new DeleteDepForm().ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void DeleteEmployee()
        {
            try
            {

            
            if(EmployeeGV.Rows.Count == 0 || EmployeeGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбран ни один сотрудник!");
                return;
            }
            var id = 0;
            int.TryParse(EmployeeGV.SelectedRows[0].Cells[0].Value?.ToString(), out id);

            var firstName = EmployeeGV.SelectedRows[0].Cells[3].Value?.ToString() ?? string.Empty;
            var lastName = EmployeeGV.SelectedRows[0].Cells[2].Value?.ToString() ?? string.Empty;
            var midleName = EmployeeGV.SelectedRows[0].Cells[4].Value?.ToString() ?? string.Empty;
            var fio = $"{lastName} {firstName} {midleName}";

            if(id != 0
                && MessageBox.Show($"Вы действительно хотите удалить сотрудника {fio}?",
                            "Удаление сотрудника", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DBHelper.DeleteEntry(Constants.TableNames.EmployeesTableName, id);
                this.employeesTableAdapter.Fill(this.employeeBDDataSet.Employees);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void delTSMEmpl_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
          
        }
            

        private void delEmpl_Click(object sender, EventArgs e)
        {
             DeleteEmployee();
         
        }

        private void удалитьВСпискеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            
            if (new DeleteDepForm().ShowDialog() == DialogResult.OK)
            {
                this.departmentsTableAdapter.Fill(this.employeeBDDataSet.Departments);
               
            }
            RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void RefreshEmployes()
        {
            this.emplWorkDataTableAdapter.Fill(this.employeeBDDataSet.EmplWorkData);
            this.employeePersonalDataTableAdapter.Fill(this.employeeBDDataSet.EmployeePersonalData);
            this.employeesTableAdapter.Fill(this.employeeBDDataSet.Employees);
        }
        private void EditEmployee(bool isEditMode = false)
        {
            try
            {

            
            if (isEditMode)
            {
                if (EmployeeGV.Rows.Count == 0 || EmployeeGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Не выбран ни один сотрудник!");
                    return;
                }
                var id = 0;

                int.TryParse(EmployeeGV.SelectedRows[0].Cells[0].Value?.ToString(), out id);
                if (id != 0 && new EditEmployeeForm(true, id).ShowDialog() == DialogResult.OK)
                {
                    RefreshEmployes();
                }


            }
            else if(new EditEmployeeForm().ShowDialog() == DialogResult.OK)
            {
                RefreshEmployes();
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void editEmpl_Click(object sender, EventArgs e)
        {
            EditEmployee(true);
        }

        private void editTSMEmpl_Click(object sender, EventArgs e)
        {
            EditEmployee(true);
        }

        private void addTSMEmpl_Click(object sender, EventArgs e)
        {
            EditEmployee();
        }

        private void addEmpl_Click(object sender, EventArgs e)
        {
            EditEmployee();
        }

        private void departmentsCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        =>Application.Exit();

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                
            var parsedDate = DateTime.Now;
            if(DateTime.TryParse(((TextBox)sender).Text, out parsedDate))
            {
                var diff = DateTime.Now - parsedDate;
                var totalDays = diff.TotalDays;

                var years = Math.Floor(totalDays / 365);
                var months = Math.Floor((totalDays - years * 365)/30);
                var days = Math.Floor(totalDays - years * 365 - months * 30);

                WorkExpDisplayTxt.Text = $"Лет: {years}, месяцев: {months}, дней: {days}";
            }
            else
            {
                WorkExpDisplayTxt.Clear();
            }
            
            }
            catch (Exception ex)
            {
                WorkExpDisplayTxt.Clear();
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
