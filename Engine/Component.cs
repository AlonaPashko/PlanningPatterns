using PlanningPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.Engine
{
    internal class Component : IComponent
    {
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
