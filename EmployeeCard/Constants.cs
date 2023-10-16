using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCard
{
    /// <summary>
    /// Класс констант
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Имена таблиц
        /// </summary>
        public static class TableNames
        {
            /// <summary>
            /// Отделы
            /// </summary>
            public const string DepartmentsTableName = "Departments";
            /// <summary>
            /// Сотруднки
            /// </summary>
            public const string EmployeesTableName = "Employees";
            /// <summary>
            /// Пресональная информация о сотрудниках
            /// </summary>
            public const string EmplPersonalDataTableName = "EmployeePersonalData";
            /// <summary>
            /// Рабочая информация о сотрудниках
            /// </summary>
            public const string EmplWorkDataTableName = "EmplWorkData";

        }
        public static class FieldsName
        {
            public const string Id = "Id";
            public static class DepartmentsTable
            {
                public const string Title = "Title";
            }
            public static class EmployeesTable
            {
                public const string DepartmentId = "DepartmentId";
                public const string LastName = "LastName";
                public const string FirstName = "FirstName";
                public const string MiddleName = "MidleName";

            }
            public static class EmplPersonalDataTable
            {
                public const string EmployeeId = "EmployeeId";
                public const string Age = "Age";
                public const string BirthDay = "BirthDay";
                public const string Citizenship = "Citizenship";
                public const string Address = "Address";

            }
            public static class EmplWorkDataTable
            {
                public const string EmployeeId = "EmployeeId";
                public const string Post = "Post";
                public const string Education = "Education";
                public const string WorkExperience = "WorkExperience";

            }
        }
    }

}
