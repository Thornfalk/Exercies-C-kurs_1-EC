using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class EmployeeAddRemove
    {
        public List<Employee> employeeList = new List<Employee>();

        public void AddEmployeeToList(string fName, string lName, string socielSecurityNumber, int wage)
        {
            employeeList.Add(new Employee(fName, lName, socielSecurityNumber, wage));
        }
        public void RemovieEmployeeFromList(string socialSecurityNumber)
        {
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (employeeList[i].SocialSecurityNumber == socialSecurityNumber)
                {
                    employeeList.Remove(employeeList[i]);
                }
            }
        }
        public bool SocialSecurityNumberExists(string socialSecNumber)
        {
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (employeeList[i].SocialSecurityNumber == socialSecNumber)
                {
                    return true;
                }
            }
            return false;
        }
        public Employee getEmployee(string socialSecNumber)
        {
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (employeeList[i].SocialSecurityNumber == socialSecNumber)
                {
                    return employeeList[i];
                }
            }
            return null;
        }
    }
}
