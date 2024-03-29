﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.BehaviouralPatterns.Visitor
{
    //serializator XML

    internal class XMLVisitor : IVisitor
    {
        public void VisitPersonAcc(Person acc)
        {
            string result = "<Person><Name" + acc.Name + "</Name>" + "<Number>" +
                acc.Number + "</Number></Person>";
            Console.WriteLine(result);
        }
        
        public void VisitCompanyAcc(Company acc)
        {
            string result = "<Company><Name>" + acc.Name + "</Name>" + "<RegNumber>" +
                acc.RegNumber + "</RegNumber><Number>" + acc.Number + "</Number></Company>";
            Console.WriteLine(result);
        }

    }
}
