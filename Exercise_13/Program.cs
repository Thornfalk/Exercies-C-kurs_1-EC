using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{


    class Program
    {
        static void Main(string[] args)
        {
            DateTime _dateTimeToday = DateTime.Today;

            //Gets person name and birth of day 
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Day of birth (YYYY-MM-DD): ");
            DateTime _birthday = DateTime.Parse(Console.ReadLine());

            //Calculates persons current age and what he turns to next year
            DateTime _currentAge = _dateTimeToday.AddYears(-_birthday.Year);
            DateTime _currentAgePlus1 = _currentAge.AddYears(1);
            
            //Calculates the day person turns 100
            DateTime _turns100At = _birthday.AddYears(100);
            TimeSpan _daysTo100 = _turns100At - _dateTimeToday;

            //Calculates persons next birthday in days
            DateTime _nextBirthday = _birthday.AddYears(_currentAge.Year);
            TimeSpan _nextBirthdayInDays = _nextBirthday - _dateTimeToday;

            if (_nextBirthdayInDays.Days < 0)
            {
                Console.WriteLine(@"

Hello, {0}.
You were {1} years old, but turned {2} {3} days ago. CONGRATULATIONS!
Your 100th birthday will be on a {4}
", name, _currentAge.Year, _currentAgePlus1.Year, _nextBirthdayInDays.Days, _turns100At.DayOfWeek);
            }
            else
            {
                Console.WriteLine(@"

Hello, {0}.
You are {1} years old, and will turn {2} in {3} days.
Your 100th birthday will be on a {4}
", name, _currentAge.Year, _currentAgePlus1.Year, _nextBirthdayInDays.Days, _turns100At.DayOfWeek);
            }
            Console.ReadKey();
        }
    }
}
