using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns
{
    internal class Car : Vehicle
    {
        private void EngageIgnition()
        {
            //Ignition procedure
        }
        public void StartEngine()
        {
            this.EngageIgnition();
            base.StartEngine();
        }
       
    }

}
