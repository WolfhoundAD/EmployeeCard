using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeCard.Utils;

namespace EmployeeCard
{
    public partial class DeleteDepForm : Form
    {
        public DeleteDepForm()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeBDDataSet.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.employeeBDDataSet.Departments);

        }
        private void DeleteDepForm_Load(object sender, EventArgs e)
        {
            RefreshData();

        }

        private void deleteDepButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(
                "Вы действительно хотите удалить выбранную запись?", "Удалить запись",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = 0;
                int.TryParse(departmentsCB.SelectedValue.ToString(), out id);
                DBHelper.DeleteEntry("Departments", id);
                RefreshData();
            }
        }
    }
}
