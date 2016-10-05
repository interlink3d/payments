using System;

namespace ConsoleApplication
{
   public class CreditCardPayment:Payment
   {
       public string creditCardNumber {get; set;}

       public override string makePayment()
       {
           string message = string.Empty;
           if (this.amount>0 && this.creditCardNumber!= null)
           {
               message = $"Your payment of ${this.amount} has been processed by Credit Card";
           }

           return message;
       } 
   }
}