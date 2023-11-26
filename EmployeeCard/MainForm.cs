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
using System.Reflection;
using System.IO;
using WordTemplateFiller.Models;
using WordTemplateFiller;
using ExelExporter;
using EmployeeCard.exportToExcelDataSetTableAdapters;
using System.Diagnostics;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using EmployeeCard.Models;
using System.Xml.Serialization;

namespace EmployeeCard
{
    public partial class MainForm : Form
    {
        private const string templatesFolderName = "Templates";
        private const string templateFileName = "EmployeeCardTemplate.docx";
        private  string templatePath;

        private const int lastNameColumnIdx = 2;
        private const int firstNameColumnIdx = 3;
        private const int patronimicColumnIdx = 4;
        public MainForm()
        {
            InitializeComponent();
            var currentAssemblyPath = Assembly.GetEntryAssembly().Location;
            var currentFolder = Path.GetDirectoryName(currentAssemblyPath);
            templatePath = $"{currentFolder}\\{templatesFolderName}\\{templateFileName}";
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

        private void exportToWordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeGV.Rows.Count == 0)
                {
                    MessageBox.Show("Список сотрудников пуст");
                    return;
                }
                
                if(expotToWordFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var path = expotToWordFileDialog.FileName;
                    var employeeGVselectedRow = EmployeeGV.SelectedRows[0];
                    var fio = $"{employeeGVselectedRow.Cells[lastNameColumnIdx].Value} {employeeGVselectedRow.Cells[firstNameColumnIdx].Value} {employeeGVselectedRow.Cells[patronimicColumnIdx].Value}";
                    var bmList = new List<BookMark> 
                    {

                        new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "FIO",
                            BookMarkValue = fio
                        },
                         new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "CITIZENSHIP",
                            BookMarkValue = textBox3.Text
                        },
                          new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "DATE",
                            BookMarkValue = textBox2.Text
                        },
                           new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "AGE",
                            BookMarkValue = textBox1.Text
                        },
                            new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "POST",
                            BookMarkValue = textBox4.Text
                        },
                             new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "OTDEL",
                            BookMarkValue = departmentsCB.Text
                        },
                              new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "WORHYEARS",
                            BookMarkValue = WorkExpDisplayTxt.Text
                        },
                               new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "ADRESS",
                            BookMarkValue = addresTxt.Text
                        },
                               new BookMark
                        {
                            BookMarkType = BookMarkType.Text,
                            BookMarkName = "EDUCATION",
                            BookMarkValue = educationTxt.Text
                        }
                    };

                    new DocumentManager(templatePath, bmList).saveDocument(path);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void exportDBtoExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (exportToExcelDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = exportToExcelDialog.FileName;
                    new ExcelExportManager().ExportDataSet(employeeBDDataSet, filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void exportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (exportToExcelDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = exportToExcelDialog.FileName;

                    var departmentId = 0;
                    int.TryParse(departmentsCB.SelectedValue.ToString(), out departmentId);

                    var exportTableAdapter = new ExportToExcelTableAdapter();
                    exportTableAdapter.Fill(exportToExcelDataSet.Сотрудники, departmentId);

                    new ExcelExportManager().ExportDataSet(exportToExcelDataSet, filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void imageNameHidenField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var currentAssemblyPath = Assembly.GetEntryAssembly().Location;
                var currentFolder = Path.GetDirectoryName(currentAssemblyPath);
                var imageName = ((TextBox)sender).Text;
                fotoPictureBox_2.ImageLocation = !string.IsNullOrEmpty(imageName) ? $"{currentFolder}\\ImgData\\{imageName}" : null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void openCardBtn_Click(object sender, EventArgs e)
        {
            try
            {

                var currentAssemblyPath = Assembly.GetEntryAssembly().Location;
                var currentFolder = Path.GetDirectoryName(currentAssemblyPath);
                if(!string.IsNullOrEmpty(cardField.Text))
                {
                    var path = $"{currentFolder}\\CardsData\\{cardField.Text}";
                    Process.Start(new ProcessStartInfo(path));
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void excelImportBtn_Click(object sender, EventArgs e)
        {
            try
            {

            
            var departmentId = 0;
           if (int.TryParse(departmentsCB.SelectedValue.ToString(), out departmentId))
            {

            
            if (excelImportFileDialog.ShowDialog() == DialogResult.OK)
            {
                var data = new List<List<string>>();
                using (var fs = new FileStream(excelImportFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                { 
                using (var doc = SpreadsheetDocument.Open(fs, false))
                {
                        var workbookPart = doc.WorkbookPart;
                        var worksheetPart = workbookPart.WorksheetParts.FirstOrDefault(wsp => wsp.Uri.OriginalString.IndexOf("sheet1") != -1);
                        var sheetData = worksheetPart?.Worksheet.Elements<SheetData>().FirstOrDefault();

                        foreach (var row in sheetData.Elements<Row>())
                        {
                            var rowData = new List<string>();

                            foreach (var cell in row.Elements<Cell>())
                            {
                                    var value = cell.InnerText;

                                    if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
                                    {
                                        int index = int.Parse(value);
                                        value = workbookPart.SharedStringTablePart.SharedStringTable
                                            .Elements<SharedStringItem>().ElementAt(index).InnerText;
                                    }
                                    rowData.Add(value);
                            }
                            data.Add(rowData);
                        }
                }
                }

                foreach (var dataRow in data)
                {
                    AddEmployeeHelper.Add(new EmployeeDto
                    {
                        
                        Address = dataRow[Constants.ExcelCells.J],
                        Age = dataRow[Constants.ExcelCells.D],
                        BirthDay = dataRow[Constants.ExcelCells.E],
                        Citizenship = dataRow[Constants.ExcelCells.H],
                        DepartmentId = departmentId.ToString(),
                        Education = dataRow[Constants.ExcelCells.I],
                        EmployeeId = string.Empty,
                        FirstName = dataRow[Constants.ExcelCells.B],
                        LastName = dataRow[Constants.ExcelCells.A],
                        MiddleName = dataRow[Constants.ExcelCells.C],
                        Post = dataRow[Constants.ExcelCells.F],
                        WorkExperience = dataRow[Constants.ExcelCells.G]
                    }) ;
                }
                    RefreshData();
            }
        }
           else
            {
                MessageBox.Show("Не удалось получить идентефиктор отдела!");
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
    }

        private void xmlExportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (xmlSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = xmlSaveFileDialog.FileName;

                    var departmentId = 0;
                    int.TryParse(departmentsCB.SelectedValue.ToString(), out departmentId);

                    var exportTableAdapter = new ExportToExcelTableAdapter();
                    exportTableAdapter.Fill(exportToExcelDataSet.Сотрудники, departmentId);

                    var employeesList = exportToExcelDataSet.Сотрудники.Select(emp => {
                        return new EmployeeToXml
                        {
                            Address = emp.Адрес,
                            Age = emp.Возраст.ToString(),
                            BirthDay = emp.Дата_рождения,
                            Citizenship = emp.Гражданство,
                            Education = emp.Образование,
                            FirstName = emp.Имя,
                            LastName = emp.Фамилия,
                            MidleName = emp.Отчество,
                            Post = emp.Должность,
                            WorkExperience = emp.Стаж

                        };
                    }).ToList();

                    var employeesToXmlList = new EmployeeToXmlList
                    {
                        Items = employeesList

                    };

                    var serializer = new XmlSerializer(typeof(EmployeeToXmlList));

                    using (var writer = new StreamWriter(filePath))
                    {
                        serializer.Serialize(writer, employeesToXmlList);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void xmlImportBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
