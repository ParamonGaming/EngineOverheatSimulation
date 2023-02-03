using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineOverheatSimulation
{
    class FirstTestEngine : InternalCombustionEngine
    {
        public FirstTestEngine()
        {
            I = 10; 
            M = new double[6]{ 20,75,100,105,75,0};
            V = new double[6]{ 0, 75, 150, 200, 250, 300 };
            TOverheat = 110;
            HM = 0.01;
            HV = 0.0001;
            C = 0.1;
        }
    }
}
