using System;
using System.Collections.Generic;
using System.Text;

namespace MVCDI
{
    class PaymentService : IPaymentService
    {
        public void PayCreditCard()
        {
            Console.WriteLine("PaymentService.PayCreditCard()");
        }
    }
}
