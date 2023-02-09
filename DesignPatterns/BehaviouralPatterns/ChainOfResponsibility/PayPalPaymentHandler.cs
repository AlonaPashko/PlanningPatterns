using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.BehaviouralPatterns.ChainOfResponsibility
{
    internal class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Reciever reciever)
        {
            if(reciever.PayPalTransfer == true)
            {
                Console.WriteLine("The PayPal transfer is performing");
            }
            else if (Successor != null)
            {
                Successor.Handle(reciever);
            }
        }
    }
}
