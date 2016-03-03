using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Employee
    {
        //This is called "Class Variables" , "Class Members" , "Fields" or even "Backing fields"
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;

        //This two properties NEEDS to have a Class Member like above
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }
        public string FullName { get { return this._firstName +" "+ this._lastName; } }
        //This below is called a "auto property" _It does everything that the above does_ but
        //gets and sets the variable INSIDE THE PROPERTY wothout any need for declaration any class variable.
        public string  SocialSecurityNumber { get; set; }
        public int HourlyWage { get; set; }

        public Employee(string _firstName, string _lastName, string _socialSecurityNumber, int _hourlyWage)
        {
            this._firstName = _firstName;
            this._lastName = _lastName;
            this.SocialSecurityNumber = _socialSecurityNumber;
            this.HourlyWage = _hourlyWage;
        }
        public Employee(string _socialSecurityNumber)
        {
            this.SocialSecurityNumber = _socialSecurityNumber;
        }
    }
}
