using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineOverheatSimulation
{
    public abstract class InternalCombustionEngine : IEngine
    {
        protected double I;
        protected double[] M;
        protected double[] V;
        protected double _realV;
        protected double _realM;
        protected int TOverheat;
        protected double HM;
        protected double HV;
        protected double C;
        protected double _engineTemperature;
        public int WorkTime { get; set; } = 0;
        public virtual double Acceleration
        {
            get
            {
                return _realM / I;
            }
        }
        public void Start(double surroundingTemperature)
        {
            _realV = V[0];
            _realM = M[0];
            _engineTemperature = surroundingTemperature;
            EngineWork(surroundingTemperature);
        }
        public double HeatingSpeed
        {
            get
            {
                return (_realM * HM) + (_realV * _realV * HV);
            }
        }
        public double CoolingSpeed(double surroundingTemperature)
        {
            return C * (surroundingTemperature - _engineTemperature);
        }
        private void EngineWork(double surroundingTemperature)
        {
            
            int currentLinear = 0;
            while (_engineTemperature < TOverheat && WorkTime<=1000)
            {
                _realV += Acceleration;
                if (_realV >= V[currentLinear + 1])
                {
                    currentLinear++;
                }
                calculateRealM(currentLinear);
                _engineTemperature += HeatingSpeed + CoolingSpeed(surroundingTemperature);
                WorkTime++;
            }
            Stop();
        }
        private void calculateRealM(int i)
        {
            double slope = (M[i + 1] - M[i]) / (V[i + 1] - V[i]);
            _realM = M[i] + slope * (_realV - V[i]);
        }

        public void Stop()
        {
            Console.WriteLine($"Engine was stoped after {WorkTime} seconds with {_engineTemperature} - C temperature ");
        }
    }
}
