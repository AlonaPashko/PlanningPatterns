using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.StructuralPatterns.Decorator
{
    internal class WithWhippedCream : CakeDecorator
    {
        public WithWhippedCream(ICake cake) : base(cake) { }
  
        public override string Ingredients()
        {
            return this.cake.Ingredients() + " with whipped cream";
        }

        public override double Price()
        {
            return this.cake.Price() + 2.5;
        }
    }
}
