using System;
using System.Collections.Generic;
using System.Text;

namespace MVCDI
{
    class OrderController
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public void Index()
        {
            this.orderService.CreateOrder();
        }
    }
}
