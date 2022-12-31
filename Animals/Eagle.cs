using PlanningPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.Animals
{
    internal class Eagle : Animal, IFlying
    {
        public int FlySped { get; set; }

        public void Fly()
        {
           //Fly implementation
        }
    }
}
