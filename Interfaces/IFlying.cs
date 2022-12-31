using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.Interfaces
{
    internal interface IFlying
    {
        int FlySped { get; set; }
        void Fly();
    }
}
