using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.BehaviouralPatterns.Strategy
{
    internal class Car
    {
        protected int passengers;
        protected string model;
        public IMovable Movable { get; set; }

        public Car(int num, string model, IMovable mov)
        {
            this.passengers = num;
            this.model = model;
            Movable = mov;
        }
        public void Move()
        {
            Movable.Move();
        }
    }
}
