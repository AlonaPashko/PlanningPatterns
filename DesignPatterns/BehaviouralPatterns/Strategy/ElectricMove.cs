using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.BehaviouralPatterns.Strategy
{
    internal class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("A moving with electricity");
        }
    }
}
