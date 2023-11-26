﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeCard.Models;
using EmployeeCard.Utils;

namespace EmployeeCard
{
    public partial class EditEmployeeForm : Form
    {
        private bool _isEditMode = false;
        private int _id = 0;
        private byte[] _photo;
        private string _photoPath;
        private string _cardPath;
        private string currentFolder;

        public EditEmployeeForm()
        {
            InitializeComponent();
        }
        public EditEmployeeForm(bool isEditMode, int id)
        {
            _isEditMode = isEditMode;
            _id = id;
            InitializeComponent();
            currentFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            this.departmentsTableAdapter.Fill(this.employeeBDDataSet.Departments);
            if (_isEditMode)
            {
                this.dataTable1TableAdapter.Fill(this.editEmployeeDataSet.DataTable1, _id);
                var employeeData = dataTable1TableAdapter.GetData(_id);
                if (employeeData?.Count > 0)
                {
                    var departmentId = employeeData.FirstOrDefault()?.DepartmentId ?? 0;
                    comboBoxDep.SelectedValue = departmentId;
                   
                }
                chosePhotoBtn.Visible = true;
                chooseCardBtn.Visible = false;
            }
            else
            {
                chosePhotoBtn.Visible = false;
                chooseCardBtn.Visible = true;
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            /*
            //Поля сотрудника
            var employeeFields = new Dictionary<string, TableField>();
            employeeFields.Add(Constants.FieldsName.EmployeesTable.DepartmentId, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = comboBoxDep.SelectedValue.ToString()
            });
            employeeFields.Add(Constants.FieldsName.EmployeesTable.LastName, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = textBoxLastName.Text
            });
            employeeFields.Add(Constants.FieldsName.EmployeesTable.FirstName, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = textBoxFirstName.Text
            });
            employeeFields.Add(Constants.FieldsName.EmployeesTable.MiddleName, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = textBoxMiddleName.Text
            });

            //Поля персональных данных сотрудников
            var personalDataFields = new Dictionary<string, TableField>();
            personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.EmployeeId, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = String.Empty
            });
            personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.Age, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = Math.Ceiling((DateTime.Now - dateTimePickerBirthDay.Value).TotalDays / 365).ToString()
            });
            personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.BirthDay, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = dateTimePickerBirthDay.Value.ToString("dd.MM.yyyy")
            });
            personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.Citizenship, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = textBoxCitizenship.Text
            });
            personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.Address, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = richTextBoxAddres.Text
            });
            //Поля рабочих данных сотрудников
            var workDataFields = new Dictionary<string, TableField>();
            workDataFields.Add(Constants.FieldsName.EmplWorkDataTable.EmployeeId, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = String.Empty
            });
            workDataFields.Add(Constants.FieldsName.EmplWorkDataTable.Post, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = textBoxPost.Text
            });
            workDataFields.Add(Constants.FieldsName.EmplWorkDataTable.Education, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = richTextBoxEducation.Text
              
            });
            workDataFields.Add(Constants.FieldsName.EmplWorkDataTable.WorkExperience, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = dateTimePickerWorkExperience.Value.ToString("dd.MM.yyyy")
            }) ;

            if (!string.IsNullOrEmpty(_cardPath))
            {
                var currentFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                var technicalCardName = $"{DateTime.Now.ToString($"yyyy_MM_dd_hh_ss_ms")}.docx";

                File.Copy(_cardPath, $"{currentFolder}\\CardsData\\{technicalCardName}", true);

                workDataFields.Add(Constants.FieldsName.EmplWorkDataTable.WorkCard, new TableField
                {
                    TableFieldType = TableFieldTypes.nvarchar,
                    TableFieldValue = technicalCardName
                });
            }

            if (_isEditMode)
            {
                if (!string.IsNullOrEmpty(_photoPath))
                {
                    var currentFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                    var technicalFileName = $"{DateTime.Now.ToString($"yyyy_MM_dd_hh_ss_ms")}{Path.GetExtension(_photoPath)}";

                    File.Copy(_photoPath, $"{currentFolder}\\ImgData\\{technicalFileName}", true);
                    personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.PhotoFileName, new TableField
                    {
                        TableFieldType = TableFieldTypes.nvarchar,
                        TableFieldValue = technicalFileName
                    });
                }

                personalDataFields[Constants.FieldsName.EmplPersonalDataTable.EmployeeId].TableFieldValue
                   = _id.ToString();
                workDataFields[Constants.FieldsName.EmplWorkDataTable.EmployeeId].TableFieldValue
                    = _id.ToString();
                DBHelper.UpdateEntry(Constants.TableNames.EmployeesTableName, _id, employeeFields);
                DBHelper.UpdateEntry(Constants.TableNames.EmplPersonalDataTableName, new FieldForUpdate
                {
                    FieldName = Constants.FieldsName.EmplPersonalDataTable.EmployeeId,
                    FieldValue = new TableField
                    {
                        TableFieldType = TableFieldTypes.integer,
                        TableFieldValue = _id.ToString()
                    }
                }, personalDataFields);

                DBHelper.UpdateEntry(Constants.TableNames.EmplWorkDataTableName, new FieldForUpdate
                {
                    FieldName = Constants.FieldsName.EmplWorkDataTable.EmployeeId,
                    FieldValue = new TableField
                    {
                        TableFieldType = TableFieldTypes.integer,
                        TableFieldValue = _id.ToString()
                    }
                }, workDataFields);

               
                
                DialogResult = DialogResult.OK;

            }
            else
            {
                var employeeId = DBHelper.InsertEntry(Constants.TableNames.EmployeesTableName, employeeFields);
                personalDataFields[Constants.FieldsName.EmplPersonalDataTable.EmployeeId].TableFieldValue
                    = employeeId.ToString();
                workDataFields[Constants.FieldsName.EmplWorkDataTable.EmployeeId].TableFieldValue
                    = employeeId.ToString();
                DBHelper.InsertEntry(Constants.TableNames.EmplPersonalDataTableName, personalDataFields);
                DBHelper.InsertEntry(Constants.TableNames.EmplWorkDataTableName, workDataFields);
                DialogResult = DialogResult.OK;
            }
            */
            AddEmployeeHelper.Add(new EmployeeDto
            {
                Address = richTextBoxAddres.Text,
                Age = Math.Ceiling((DateTime.Now - dateTimePickerBirthDay.Value).TotalDays / 365).ToString(),
                BirthDay = dateTimePickerBirthDay.Value.ToString("dd.MM.yyyy"),
                CardPath = _cardPath,
                Citizenship = textBoxCitizenship.Text,
                DepartmentId = comboBoxDep.SelectedValue.ToString(),
                Education = richTextBoxEducation.Text,
                EmployeeId = _id.ToString(),
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                MiddleName = textBoxMiddleName.Text,
                PhotoPath = _photoPath,
                Post = textBoxPost.Text,
                WorkExperience = dateTimePickerWorkExperience.Value.ToString("dd.MM.yyyy")
            }, _isEditMode) ;
            DialogResult = DialogResult.OK;
        }

        private void chosePhotoBtn_Click(object sender, EventArgs e)
        {
            if(choseImageDialog.ShowDialog() == DialogResult.OK)
            {
               // var path = choseImageDialog.FileName;
                //_photo = File.ReadAllBytes(path);

                 _photoPath = choseImageDialog.FileName;

             }
        }

        private void chooseCardBtn_Click(object sender, EventArgs e)
        {
            if (chooseCardFileDialog.ShowDialog() == DialogResult.OK)
            {
               
                _cardPath = chooseCardFileDialog.FileName;

            }
        }
    }
}
