using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns
{
    internal class ElectricBus : Vehicle
    {
        private void IncreaseVoltage()
        {
            //Electric Logic
        }
        private void ConecctIndividualEngines()
        {
            //Connecting Logic
        }
        public void Accelerate()
        {
            this.IncreaseVoltage();
            this.ConecctIndividualEngines();
        }
    }
}
