using System;
using Microsoft.Extensions.DependencyInjection;

namespace MVCDI
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddTransient<OrderController>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IPaymentService, PaymentService>();

            var serviceProvider = services.BuildServiceProvider();

            OrderController orderController = serviceProvider.GetService<OrderController>();
            orderController.Index();
        }
    }
}
