using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class Client
    {
        private IAbstractProductA abstractProductA;
        private IAbstractProductB abstractProductB;

        public Client(IAbstractFactory factory)
        {
            abstractProductB = factory.CreateProductB();
            abstractProductA = factory.CreateProductA();
        }
        public void Run() { }
    }
}
