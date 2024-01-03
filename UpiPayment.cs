using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class UpiPayment : IPaymentProvider
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing UPI Payment: {amount:C}");
            // Logic for PayPal payment processing...
        }
    }
}
