using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.StructuralPatterns.Decorator
{
    internal class WithSprinkles : CakeDecorator
    {
        public WithSprinkles(ICake cake) : base(cake) { }

        public override string Ingredients()
        {
            return this.cake.Ingredients() + " with sprinkles";
        }

        public override double Price()
        {
            return this.cake.Price() + 1.25;
        }
    }
}
