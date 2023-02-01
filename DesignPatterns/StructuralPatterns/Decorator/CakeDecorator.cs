using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.StructuralPatterns.Decorator
{
    abstract class CakeDecorator : ICake
    {
        protected ICake cake;

        public CakeDecorator(ICake cake)
        {
            this.cake = cake;
        }
        
        public abstract string Ingredients();
        public abstract double Price();
       
    }
}
