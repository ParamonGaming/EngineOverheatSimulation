using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineOverheatSimulation
{
    public interface IEngine
    {
        int WorkTime { get; set; }
        void Start(double temperature);
        void Stop();
    }
}
