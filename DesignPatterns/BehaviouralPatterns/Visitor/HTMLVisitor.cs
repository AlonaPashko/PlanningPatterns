﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.BehaviouralPatterns.Visitor
{
    //serializator HTML
    
    internal class HTMLVisitor : IVisitor
    {
        public void VisitPersonAcc(Person acc)
        {
            string result = "<table><tr><td>Property</td><td>Value</td></tr>";
            result += "<tr><td>Name</td><td>" + acc.Name + "</td></tr>";
            result += "<tr><td>Number</td><td>" + acc.Number + "</td></tr></table>";
            Console.WriteLine(result);

        }

        public void VisitCompanyAcc(Company acc)
        {
            string result = "<table><tr><td>Property</td><td>Value</td></tr>";
            result += "<tr><td>Name</td><td>" + acc.Name + "</td></tr>";
            result += "<tr><td>RegNumber</td><td>" + acc.RegNumber + "</td></tr>";
            result += "<tr><td>Number</td><td>" + acc.Number + "</td></tr></table>";
            Console.WriteLine(result);
        }
        
    }
}
