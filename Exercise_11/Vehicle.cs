using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    abstract class Vehicle
    {
        protected string _type;
        
        public Vehicle(string type)
        {
            this._type = type;
        }
        public virtual string DescribeVehicle()
        {
            return _type;
        }
        
    }
}
