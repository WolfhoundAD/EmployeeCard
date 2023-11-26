using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCard.Models
{
    public class EmployeeDto
    {
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Age { get; set; }
        public string BirthDay { get; set; }
        public string Citizenship { get; set; }
        public string Address { get; set; }
        public string Post { get; set; }
        public string Education { get; set; }
        public string WorkExperience { get; set; }
        public string CardPath { get; set; }
        public string PhotoPath { get; set; }


    }
}
