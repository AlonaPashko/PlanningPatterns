using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.StructuralPatterns.Facade
{
    internal class CLR
    {
        public void Execute()
        {
            Console.WriteLine("Execution of the application");
        }
        public void Finish()
        {
            Console.WriteLine("Shut down");
        }
    }
}
