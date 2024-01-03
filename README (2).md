
# Open/Closed Principle (OCP)

The Open/Closed Principle (OCP) is one of the SOLID principles in object-oriented design. It states that a class should be open for extension but closed for modification. This means that the behavior of a class can be extended without modifying its source code. Let's explore the Open/Closed Principle with an example related to a payment provider:

# Overview: 

The Open/Closed Principle encourages designing classes that can be extended to incorporate new functionalities without altering the existing code. This principle promotes a modular and flexible design, allowing for easy addition of new features.




## Key Points

- Extension without Modification: The behavior of a class should be extendable by adding new code rather than modifying existing code. This ensures that existing functionalities are not affected when new features are introduced.


## Example of Violating SRP

```javascript
public class PaymentProcessor
{
    public void ProcessPayment(string paymentMethod, decimal amount)
    {
        if (paymentMethod == "CreditCard")
        {
            // Code to process credit card payment...
        }
        else if (paymentMethod == "PayPal")
        {
            // Code to process PayPal payment...
        }
        // More payment methods...
    }
}
```

In this example, adding a new payment method requires modifying the existing ProcessPayment method, violating OCP.

## Applying SRP

```javascript
public abstract class PaymentProvider
{
    public abstract void ProcessPayment(decimal amount);
}

public class CreditCardPaymentProvider : PaymentProvider
{
    public override void ProcessPayment(decimal amount)
    {
        // Code to process credit card payment...
    }
}

public class PayPalPaymentProvider : PaymentProvider
{
    public override void ProcessPayment(decimal amount)
    {
        // Code to process PayPal payment...
    }
}
```
By introducing an abstract base class (PaymentProvider), new payment providers can be added without modifying existing code.


## Payment Manager

- Implement a payment manager that can accept any payment provider implementing IPaymentProvider.

```javascript
public class PaymentManager
{
    public void ProcessPayment(IPaymentProvider paymentProvider, double amount)
    {
        paymentProvider.ProcessPayment(amount);
    }
}
```
- Use the PaymentManager to process payments with different payment providers without modifying the existing code.

The IPaymentProvider interface defines the contract for payment providers.
Concrete implementations (CreditCardPayment and PayPalPayment) extend the behavior without modifying existing code.

The PaymentManager class follows the Open/Closed Principle by accepting any class that implements IPaymentProvider.

This design allows for easy extension by adding new payment providers without modifying the PaymentManager or existing payment provider implementations. It demonstrates how OCP contributes to a more flexible and maintainable system.



## Benefits

- Flexibility: New functionality can be added without changing existing code.
- Maintainability: Existing code remains stable during extensions.
- Scalability: Easily incorporate new features by extending classes.

With this design, adding a new payment provider involves creating a new class that inherits from PaymentProvider and implements the ProcessPayment method. Existing code in CreditCardPaymentProvider and PayPalPaymentProvider remains unchanged.


# Conclusion
The Open/Closed Principle encourages a design philosophy that anticipates change and allows for extensibility without modification. By adhering to OCP, software systems become more adaptable, scalable, and maintainable over time. The payment provider example demonstrates how new payment methods can be added without modifying existing code, making the system more resilient to change.
## 🚀 About Me
I'm a full stack developer...


## 🛠 Skills
Project Built on ASP.Net Core


## 🔗 Links
[![portfolio](https://img.shields.io/badge/my_portfolio-000?style=for-the-badge&logo=ko-fi&logoColor=white)](https://vishwaskapte.netlify.app/)

[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/vishwas-kapte-47535621/)

[![twitter](https://img.shields.io/badge/github-1DA1F2?style=for-the-badge&logo=github&logoColor=white)](https://github.com/vishwaskapte/SingleResposibilityPrinciple/)

