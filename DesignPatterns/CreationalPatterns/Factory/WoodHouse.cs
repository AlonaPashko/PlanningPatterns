using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.CreationalPatterns.Factory
{
    internal class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Wood house was created");
        }
    }
}
