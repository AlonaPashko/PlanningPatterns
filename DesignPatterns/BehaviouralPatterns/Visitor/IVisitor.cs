using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.BehaviouralPatterns.Visitor
{
    internal interface IVisitor
    {
        void VisitPersonAcc(Person acc);
        
        void VisitCompanyAcc(Company acc);
    }
}
