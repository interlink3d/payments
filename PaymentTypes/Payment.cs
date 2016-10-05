using System;

namespace ConsoleApplication
{
   public class Payment
   {
       public decimal amount{get; set;}

       public virtual string makePayment()
       {
           return $"You paid ${this.amount} in cash ";
       }
       public string sendConfirmation(string email)
       {
        return "You purchased several nice items";
       }
    }

}