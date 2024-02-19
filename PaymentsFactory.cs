using MyPaymentFactory.Model.Interface;
using MyPaymentFactory.Model.TypesPayments;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaymentFactory
{
    internal class PaymentsFactory
    {
        public static IPayments CreatePay(PaymentType paymentType)
        {

            switch (paymentType)
            {
                case PaymentType.Cash:
                    return new PaymentsCash();
                    break;
                case PaymentType.Credit:
                    return new PaymentsCredit();
                    break;
                case PaymentType.Online:
                    return new PaymentsOnline();
                default:
                    throw new NotSupportedException($"{paymentType} Not find");
            }
        }
    }
}
