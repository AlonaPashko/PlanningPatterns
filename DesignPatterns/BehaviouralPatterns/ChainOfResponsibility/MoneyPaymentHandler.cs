using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.BehaviouralPatterns.ChainOfResponsibility
{
    internal class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Reciever reciever)
        {
            if(reciever.MoneyTransfer == true)
            {
                Console.WriteLine("The money transfer is performing");
            }
            else if (Successor != null)
            {
                Successor.Handle(reciever);
            }
        }
    }
}
