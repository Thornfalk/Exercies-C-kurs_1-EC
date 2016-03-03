using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Truck: Vehicle
    {
        string _model = string.Empty;
        bool _engineIsRunning;

        public Truck(string model, bool engineIsRunning = false) : base("Truck")
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
