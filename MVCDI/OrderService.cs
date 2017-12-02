using System;
using System.Collections.Generic;
using System.Text;

namespace MVCDI
{
    class OrderService: IOrderService
    {
        private readonly IPaymentService paymentService;

        public OrderService(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        public void CreateOrder()
        {
            this.paymentService.PayCreditCard();
        }
    }
}
