using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {

        //EXERCISE 12 FINNISH
        static void Main(string[] args)
        {
            var logger = new Logger();
            var application = new LogApplication(logger);
            bool loop = true;
            do
            {
                Console.Clear();
                application.Run();
            } while (loop);
            Console.ReadKey();
        }
    }
}
