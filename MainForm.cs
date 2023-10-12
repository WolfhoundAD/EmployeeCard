using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;


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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeBDDataSet.EmplWorkData". При необходимости она может быть перемещена или удалена.
            this.emplWorkDataTableAdapter.Fill(this.employeeBDDataSet.EmplWorkData);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeBDDataSet.EmployeePersonalData". При необходимости она может быть перемещена или удалена.
            this.employeePersonalDataTableAdapter.Fill(this.employeeBDDataSet.EmployeePersonalData);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeBDDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.employeeBDDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeBDDataSet.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.employeeBDDataSet.Departments);
            addresTxt.ReadOnly = true;
            educationTxt.ReadOnly = true;
          


        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
