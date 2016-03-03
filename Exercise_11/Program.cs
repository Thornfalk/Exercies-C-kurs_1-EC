using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Program
    {
        //EXERCISE FÄRDIG
        static void Main(string[] args)
        {
            var car = new Car("Volvo", false);
            var truck = new Truck("Saab", true);

            VehicleData vData = new VehicleData();
            vData.PrintVehicle(car);
            vData.PrintVehicle(truck);
            Console.ReadKey();
        }
    }
}
