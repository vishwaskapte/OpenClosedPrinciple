using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class CreditCardPayment : IPaymentProvider
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Credit Card Payment: {amount:C}");
            // Logic for credit card payment processing...
        }
    }
}
