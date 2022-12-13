using PlanningPatterns.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.Interfaces
{
    internal interface IPneumaticStarter : IStarter
    {
        AirCompressor Compressor { get; set; }
    }
}
