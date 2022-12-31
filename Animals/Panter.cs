using PlanningPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.Animals
{
    internal class Panter : Animal, IRunning
    {
        public int RunningSpeed { get; set; }

        public void Run()
        {
            //Run implementation
        }
    }
}
