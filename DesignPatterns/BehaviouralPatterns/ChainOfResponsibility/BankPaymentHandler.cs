using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.BehaviouralPatterns.ChainOfResponsibility
{
    internal class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Reciever reciever)
        {
            if (reciever.BankTransfer == true)
            {
                Console.WriteLine("The bank transfer is performing");
            }
            else if (Successor != null) 
            { 
                Successor.Handle(reciever);
            }
            
        }
    }
}
