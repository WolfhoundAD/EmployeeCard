using EmployeeCard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace EmployeeCard.Utils
{
    public static class AddEmployeeHelper
    {
        public static void Add(EmployeeDto dto, bool isEditMode = false)
        {
            //Поля сотрудника
            var employeeFields = new Dictionary<string, TableField>();
            employeeFields.Add(Constants.FieldsName.EmployeesTable.DepartmentId, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = dto.DepartmentId
            });
            employeeFields.Add(Constants.FieldsName.EmployeesTable.LastName, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = dto.LastName
            });
            employeeFields.Add(Constants.FieldsName.EmployeesTable.FirstName, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = dto.FirstName
            });
            employeeFields.Add(Constants.FieldsName.EmployeesTable.MiddleName, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = dto.MiddleName
            });

            //Поля персональных данных сотрудников
            var personalDataFields = new Dictionary<string, TableField>();
            personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.EmployeeId, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = dto.EmployeeId
            });
            personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.Age, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = dto.Age
            });
            personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.BirthDay, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = dto.BirthDay
            });
            personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.Citizenship, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = dto.Citizenship
            });
            personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.Address, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = dto.Address
            });
            //Поля рабочих данных сотрудников
            var workDataFields = new Dictionary<string, TableField>();
            workDataFields.Add(Constants.FieldsName.EmplWorkDataTable.EmployeeId, new TableField
            {
                TableFieldType = TableFieldTypes.integer,
                TableFieldValue = dto.EmployeeId
            });
            workDataFields.Add(Constants.FieldsName.EmplWorkDataTable.Post, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = dto.Post
            });
            workDataFields.Add(Constants.FieldsName.EmplWorkDataTable.Education, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = dto.Education

            });
            workDataFields.Add(Constants.FieldsName.EmplWorkDataTable.WorkExperience, new TableField
            {
                TableFieldType = TableFieldTypes.nvarchar,
                TableFieldValue = dto.WorkExperience
            });

            if (!string.IsNullOrEmpty(dto.CardPath))
            {
                var currentFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                var technicalCardName = $"{DateTime.Now.ToString($"yyyy_MM_dd_hh_ss_ms")}.docx";

                File.Copy(dto.CardPath, $"{currentFolder}\\CardsData\\{technicalCardName}", true);

                workDataFields.Add(Constants.FieldsName.EmplWorkDataTable.WorkCard, new TableField
                {
                    TableFieldType = TableFieldTypes.nvarchar,
                    TableFieldValue = technicalCardName
                });
            }

            if (isEditMode)
            {
                if (!string.IsNullOrEmpty(dto.PhotoPath))
                {
                    var currentFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                    var technicalFileName = $"{DateTime.Now.ToString($"yyyy_MM_dd_hh_ss_ms")}{Path.GetExtension(dto.PhotoPath)}";

                    File.Copy(dto.PhotoPath, $"{currentFolder}\\ImgData\\{technicalFileName}", true);
                    personalDataFields.Add(Constants.FieldsName.EmplPersonalDataTable.PhotoFileName, new TableField
                    {
                        TableFieldType = TableFieldTypes.nvarchar,
                        TableFieldValue = technicalFileName
                    });
                }

                personalDataFields[Constants.FieldsName.EmplPersonalDataTable.EmployeeId].TableFieldValue
                   = dto.EmployeeId;
                workDataFields[Constants.FieldsName.EmplWorkDataTable.EmployeeId].TableFieldValue
                    = dto.EmployeeId;
                DBHelper.UpdateEntry(Constants.TableNames.EmployeesTableName, int.Parse(dto.EmployeeId), employeeFields);
                DBHelper.UpdateEntry(Constants.TableNames.EmplPersonalDataTableName, new FieldForUpdate
                {
                    FieldName = Constants.FieldsName.EmplPersonalDataTable.EmployeeId,
                    FieldValue = new TableField
                    {
                        TableFieldType = TableFieldTypes.integer,
                        TableFieldValue = dto.EmployeeId
                    }
                }, personalDataFields);

                DBHelper.UpdateEntry(Constants.TableNames.EmplWorkDataTableName, new FieldForUpdate
                {
                    FieldName = Constants.FieldsName.EmplWorkDataTable.EmployeeId,
                    FieldValue = new TableField
                    {
                        TableFieldType = TableFieldTypes.integer,
                        TableFieldValue = dto.EmployeeId
                    }
                }, workDataFields);
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
              
            }
        }
    }
}
