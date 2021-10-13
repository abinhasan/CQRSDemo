using CQRSDemo.Models;
using CQRSDemo.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemo.Features.Orders.Commands
{
    public class CreateOrderCommand : IRequest<Order>
    {
        public int? CustomerId { get; set; }
        public int? ShipperId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? Discount { get; set; }
        public string DeliveryAddress { get; set; }
        public string Mobile { get; set; }

        public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Order>
        {
            private readonly IOrdersService _orderService;

            public CreateOrderCommandHandler(IOrdersService orderService)
            {
                _orderService = orderService;
            }

            public async Task<Order> Handle(CreateOrderCommand command, CancellationToken cancellationToken)
            {
                var order = new Order()
                {
                    CustomerId = command.CustomerId,
                    ShipperId = command.ShipperId,
                    OrderDate = DateTime.Now,
                    Discount = command.Discount,
                    DeliveryAddress = command.DeliveryAddress,
                    Mobile = command.Mobile
                };

                return await _orderService.CreateOrder(order);
            }
        }
    }
}
