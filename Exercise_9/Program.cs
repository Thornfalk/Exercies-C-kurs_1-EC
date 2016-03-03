using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{


    //EXERCISE FÄRDIG
    class Program
    {
        static void Main(string[] args)
        {
            bool _loop = true;
            string logPostInfo = string.Empty;
            var _employee = new Employee("", "","",0);
            var _empAddRemove = new EmployeeAddRemove();
            var _logger = new Logger();
            string fName = string.Empty;
            string lName = string.Empty;
            string socialSecurityNumber = string.Empty;


            _empAddRemove.AddEmployeeToList("Kalle", "Anka", "1938", 100);
            _empAddRemove.AddEmployeeToList("Musse", "Pigg", "1966", 150);
            _empAddRemove.AddEmployeeToList("Klasse", "Häst", "1972", 120);
            do
            {
                Console.WriteLine(@"
1. Add employee
2. Remove employee
3. Print entire registry
4. Look at Logger
5. Exit program

- - - - - - - - - -
");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();
                bool exist = false;
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nAdd employee to list\n");
                        Console.Write("Employee First Name: ");
                        fName = Console.ReadLine();
                        Console.Write("Employee Last Name: ");
                        lName = Console.ReadLine();
                        Console.Write("Employee SecurityNumber: ");
                        socialSecurityNumber = Console.ReadLine();
                        Console.Write("Employee hourly wage: ");
                        int wage = int.Parse(Console.ReadLine());
                        _empAddRemove.AddEmployeeToList(fName, lName, socialSecurityNumber, wage);
                        Console.WriteLine("\nNew employee added to list!");
                        Console.ReadLine();
                        logPostInfo = $"New employee added to list!\nAdded: {DateTime.Now}:\n- Name  : {fName} {lName}\n- Number: {socialSecurityNumber}";
                        _logger.Log(logPostInfo);
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        foreach (var employer in _empAddRemove.employeeList)
                        {
                            Console.WriteLine(" - Employee Name  : " + employer.FullName);
                            Console.WriteLine(" - Security Number: " + employer.SocialSecurityNumber);
                            Console.WriteLine("\n- - - - - - - - - - - - - -\n");
                        }
                        if (_empAddRemove.employeeList.Count < 0)
                            Console.WriteLine("There are no Employers registrated");
                        else
                        {
                            Console.WriteLine("\nEnter social security number");
                            Console.Write("\nEnter choice: ");
                            socialSecurityNumber = Console.ReadLine();
                            exist = _empAddRemove.SocialSecurityNumberExists(socialSecurityNumber);
                            if (exist == true)
                            {
                                Console.WriteLine("\n" + socialSecurityNumber + " FOUND!");
                                Console.WriteLine("\nRemove {0}? (y/n)", socialSecurityNumber);
                                if (Console.ReadLine() == "y")
                                {
                                    var removeEmployee = _empAddRemove.getEmployee(socialSecurityNumber);
                                    Console.WriteLine("\nEmployee removed from list");
                                    _empAddRemove.RemovieEmployeeFromList(socialSecurityNumber);

                                    logPostInfo = $"Employee removed from list\nRemoved: {DateTime.Now}:\n- Name  : {removeEmployee.FirstName} {removeEmployee.LastName}\n- Number: {removeEmployee.SocialSecurityNumber}";
                                    _logger.Log(logPostInfo);
                                }
                                else
                                    Console.WriteLine("Return without removing..");
                            }
                            else
                                Console.WriteLine("\nSocial Security Number NOT FOUND..");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case "3":
                        Console.Clear();
                        foreach (var employer in _empAddRemove.employeeList)
                        {
                            Console.WriteLine(" - Employee Name  : "+employer.FullName);
                            Console.WriteLine(" - Security Number: "+employer.SocialSecurityNumber);
                            Console.WriteLine(" - Hourly Wage    : "+employer.HourlyWage);
                            Console.WriteLine("\n- - - - - - - - - - - - - -\n");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        //INSERT LOGGER CLASS HERE

                        Console.WriteLine("\n- - - - - - - - - -");
                        _logger.PrintLoggerList();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.WriteLine("Exit Program");
                        Console.ReadKey();
                        _loop = false;
                        return;
                    default:
                        break;
                }
            } while (_loop == true);
            Console.ReadKey();
        }
    }
}
