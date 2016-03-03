using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Car: Vehicle
    {
        string _model = string.Empty;
        bool _engineIsRunning;
        public Car(string model, bool engineIsRunning = false) : base("Car")
        {
            this._model = model;
            this._engineIsRunning = engineIsRunning;
        }
        public override string DescribeVehicle()
        {
            string result = $"This is a {_type}, ";
            if (_engineIsRunning == true)
                result += "and the engine is running";
            else
                result += "and engine is not running";
            return result;
        }


        public void StartEngine()
        {
            _engineIsRunning = true;
        }
        public void StopEngine()
        {
            _engineIsRunning = false;
        }
    }
}
