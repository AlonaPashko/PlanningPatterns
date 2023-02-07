using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.BehaviouralPatterns.Visitor
{
    internal class Company : IAccount
    {
        public string Name { get; set; }
        public int RegNumber { get; set; }
        public int Number { get;set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompanyAcc(this);
        }
    }
}
