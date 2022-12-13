using PlanningPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.Engine
{
    internal class PneumaticStarter : Component, IPneumaticStarter
    {
        public AirCompressor Compressor { get; set; }

        public IgnitionResult Start()
        {
            return IgnitionResult.Success;
        }
    }
}
