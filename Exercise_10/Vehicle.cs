using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Vehicle
    {
        string _type;
        public Vehicle(string type)
        {
            this._type = type;
        }
        public string DescribeVehicle()
        {
            return $"This vehicle is a {_type}";
        }
    }
}
