﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.CreationalPatterns.AbstractFactory
{
    internal interface IAbstractFactory
    {
        public IAbstractProductA CreateProductA();

        public IAbstractProductB CreateProductB();


    }
}
