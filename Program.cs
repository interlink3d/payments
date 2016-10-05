using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var paymentType = args[0];
            if (paymentType == "p")
            {
                var pppayment = new PayPalPayment
                {
                    email = args[1],
                    password = args[2],
                    amount = Convert.ToDecimal(args[3])
                };

                Console.WriteLine(pppayment.makePayment());
            }
            
            if (paymentType == "c")
            {
                var ccpayment = new CreditCardPayment
                {
                    creditCardNumber = args[1],
                    amount = Convert.ToDecimal(args[2])
                };
                Console.WriteLine(ccpayment.makePayment());   
            }
        }
    }
}
