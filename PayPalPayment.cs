using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class PayPalPayment : IPaymentProvider
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal Payment: {amount:C}");
            // Logic for PayPal payment processing...
        }
    }
}
