using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.BehaviouralPatterns.ChainOfResponsibility
{
    internal class Reciever
    {
        public bool BankTransfer { get; set; }

        public bool MoneyTransfer { get; set; }

        public bool PayPalTransfer { get; set; }

        public Reciever(bool bt, bool mt, bool ppt)
        {
            BankTransfer = bt;
            MoneyTransfer = mt;
            PayPalTransfer = ppt;
        }
    }
}
