using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.StructuralPatterns.Decorator
{
    internal class SimpleCake : ICake
    {
        public string Ingredients()
        {
            return "Simple cake";
        }

        public double Price()
        {
            return 12.5;
        }
    }
}
