using MyPaymentFactory;
using MyPaymentFactory.Model.Interface;

IPayments payments = PaymentsFactory.CreatePay(PaymentType.Cash);

payments.Payments(1000.00);

