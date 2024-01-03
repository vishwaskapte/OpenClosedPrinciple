// See https://aka.ms/new-console-template for more information
using OpenClosedPrinciple;

PaymentManager paymentManager = new PaymentManager();

// Process credit card payment
IPaymentProvider creditCardPayment = new CreditCardPayment();
paymentManager.ProcessPayment(creditCardPayment, 100.00);

// Process PayPal payment
IPaymentProvider payPalPayment = new PayPalPayment();
paymentManager.ProcessPayment(payPalPayment, 50.00);

// Process NetBanking card payment
IPaymentProvider netBankingPayment = new NetBankingPayment();
paymentManager.ProcessPayment(netBankingPayment, 241);

// Process UPI payment
IPaymentProvider upiPayment = new UpiPayment();
paymentManager.ProcessPayment(upiPayment, 125);

