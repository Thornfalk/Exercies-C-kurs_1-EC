using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
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
