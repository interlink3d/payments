using System;

namespace ConsoleApplication
{
   public class PayPalPayment:Payment
   {
       public string password {get; set;}

       public string email {get; set;}

       public override string makePayment()
       {
           string message = string.Empty;
           if (this.amount>0 && this.password!= null)
           {
               message = $"Your payment of ${this.amount} has been processed by PayPal";
           }

           return message;
       } 
   }
}