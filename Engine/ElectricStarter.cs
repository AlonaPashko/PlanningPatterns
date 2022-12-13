using PlanningPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.Engine
{
    internal class ElectricStarter : Component, IElectricStarter
    {
        public Batery batery { get; set; }

        public IgnitionResult Start()
        {
            return IgnitionResult.Success;
        }
    }
}
