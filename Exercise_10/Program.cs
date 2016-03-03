using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        //EXERCISE 10 FINNISH
        static void Main(string[] args)
        {
            VehicleData vehicleData = new VehicleData();
            Car car = new Car("Honda", false);
            Truck truck = new Truck("Saab",false);

            Console.WriteLine(car.DescribeVehicle());
            Console.WriteLine(truck.DescribeVehicle());
            Console.ReadKey();
        }
    }
}
