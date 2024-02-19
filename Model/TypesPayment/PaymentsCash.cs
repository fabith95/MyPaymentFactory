using MyPaymentFactory.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaymentFactory.Model.TypesPayments
{
    internal class PaymentsCash : IPayments
    {
        public void Payments(double amount)
        {
            Console.WriteLine($"Succesfully paid for {amount} thanks for her buy in Cash");
        }
    }
}
