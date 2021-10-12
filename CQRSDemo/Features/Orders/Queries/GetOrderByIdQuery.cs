using CQRSDemo.Models;
using CQRSDemo.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemo.Features.Orders.Queries
{
    public class GetOrderByIdQuery : IRequest<Order>
    {
        public int OrderId { get; set; }

        public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, Order>
        {
            private readonly IOrdersService _orderService;

            public GetOrderByIdQueryHandler(IOrdersService orderService)
            {
                _orderService = orderService;
            }

            public async Task<Order> Handle(GetOrderByIdQuery query, CancellationToken cancellationToken)
            {
                return await _orderService.GetOrderById(query.OrderId);
            }
        }

    }
}
