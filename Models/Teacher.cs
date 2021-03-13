using System;

namespace kalum2021.Models
{
    public class Teacher : Person
    {
        public Teacher()
        {

        }

        public Teacher(string EmployeeId)
        {
            this.EmployeeId = EmployeeId;
        }

        public Teacher(string EmployeeId, string FirstName, string LastName, string Email, DateTime Birthday, string Gender, string Phone) : base(FirstName,LastName,Email,Birthday,Gender,Phone)
        {
            this.EmployeeId= EmployeeId;
        }

        private string _employeeId;

        public string EmployeeId
        {
            get
            {
                return _employeeId;
            }
            set
            {
                _employeeId = value;
            }
        }
    }
}