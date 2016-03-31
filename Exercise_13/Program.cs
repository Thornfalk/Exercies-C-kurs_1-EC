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
            //Gets Todays date
            DateTime dateTimeToday = DateTime.Today;


            //Gets person name and birth
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Year of birth: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Month of birth: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Day of birth: ");
            int day = int.Parse(Console.ReadLine());

            DateTime personBirthday = new DateTime(year, month, day);


            //Calculates persons current age and what he turns to next year
            int currentAge = dateTimeToday.Year - personBirthday.Year;
            DateTime recentBirthday = personBirthday.AddYears(currentAge);
            if(dateTimeToday < recentBirthday)
                currentAge--;


            //Calculates persons next birthday in days and check if next year is a "leap year"
            int daysInFebruari = DateTime.DaysInMonth(DateTime.Today.Year+1, 02);

            TimeSpan nextBirthday = recentBirthday - dateTimeToday;
            int nextBirthdayInDays = 0;
            
            if(nextBirthday.Days < 1 && daysInFebruari != 29)
            {
                nextBirthdayInDays = nextBirthday.Days + 365;
            }
            else if (nextBirthday.Days < 1 && daysInFebruari == 29)
            {
                nextBirthdayInDays = nextBirthday.Days + 366;
            }
            else
            {
                nextBirthdayInDays = nextBirthday.Days;
            }
            

            //Calculates the day person turns 100
            DateTime turns100At = personBirthday.AddYears(100);
            TimeSpan daysTo100 = turns100At - dateTimeToday;
            

            //Printing out the data
                Console.WriteLine(@"
* * * * * * * * * * * * * * * * * * * * * * * * * * * * *
                                                       
- Hello, {0}.                                           
- You are {1} years old, and will turn {2} in {3} days. 
- Your 100th birthday will be on a {4}                  
                                                       
* * * * * * * * * * * * * * * * * * * * * * * * * * * * *
", name, currentAge, currentAge+1, nextBirthdayInDays, turns100At.DayOfWeek);
            Console.ReadKey();
        }
    }
}
