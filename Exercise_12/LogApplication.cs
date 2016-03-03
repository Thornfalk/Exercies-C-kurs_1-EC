using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class LogApplication
    {
        ILogger _logger;
        public LogApplication(ILogger _Logger)
        {
            this._logger = _Logger;
        }
        public void Run()
        {
            Console.WriteLine(@"

1) Add message to log
2) Print log
");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Add message: ");
                    string message = Console.ReadLine();
                    _logger.Log(message);
                    Console.WriteLine($"{message} : is stored in list");
                    Console.ReadKey();
                    break;
                case "2":
                    foreach (var log in _logger.LogPosts)
                    {
                        Console.WriteLine(log);
                    }
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
        

    }
}
