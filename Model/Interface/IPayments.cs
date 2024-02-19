using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaymentFactory.Model.Interface
{
    internal interface IPayments
    {
        void Payments(double amount);
    }

    public enum PaymentType
    {
        Cash,
        Credit,
        Online
    }
}
