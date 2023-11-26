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
                public const string PhotoFileName = "PhotoFileName";

            }
            public static class EmplWorkDataTable
            {
                public const string EmployeeId = "EmployeeId";
                public const string Post = "Post";
                public const string Education = "Education";
                public const string WorkExperience = "WorkExperience";
                public const string WorkCard = "WorkCard";

            }
        }
        public static class ExcelCells
        {
            public static int A = 0;
            public static int B = 1;
            public static int C = 2;
            public static int D = 3;
            public static int E = 4;
            public static int F = 5;
            public static int G = 6;
            public static int H = 7;
            public static int I = 8;
            public static int J = 9;

        }
    }

}
