using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class PaymentManager
    {
        public void ProcessPayment(IPaymentProvider paymentProvider, double amount)
        {
            paymentProvider.ProcessPayment(amount);
        }
    }

}
