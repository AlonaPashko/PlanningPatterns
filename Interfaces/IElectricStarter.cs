using PlanningPatterns.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.Interfaces
{
    internal interface IElectricStarter : IStarter
    {
        Batery batery { get; set; }
    }
}
