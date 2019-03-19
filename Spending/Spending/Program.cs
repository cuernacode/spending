using System;
using System.Collections.Generic;

namespace Spending
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class TriggerUnusualSpendingEmail
    {
        public void Trigger(int userId)
        {
            //obtener pagos
            //analyzar pagos grandes
            //something big spend email triggerer
        }
    }

    public class BigSpendingWarner
    {
        public void WarnBigSpending() { }
    }

    public class PaymentsFetcher
    {
        public IEnumerable<Payment> Does() { return null; }
    }

    public class Payment
    {

    }

    public class EmailsUser
    {

    }
}
