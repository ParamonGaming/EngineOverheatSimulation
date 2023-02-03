using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineOverheatSimulation
{
    internal class EngineSimulation
    {
        private IEngine _engine;
        private double _temperature;


        public EngineSimulation(IEngine engine, double temperature)
        {
            _engine = engine;
            _temperature= temperature;
        }
        public void StartTest()
        {
            _engine.Start(_temperature);
            if(_engine.WorkTime >=1000)
            {
                Console.WriteLine("Engine is not overheating");
            }
            else
            {
                Console.WriteLine($"Eingine is overheating for {_engine.WorkTime} seconds");
            }
        }
    }
}
