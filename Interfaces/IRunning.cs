using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.Interfaces
{
    internal interface IRunning
    {
        int RunningSpeed { get; set; }
        void Run();
    }
}
