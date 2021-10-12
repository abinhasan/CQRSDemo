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
    public class GetAllOrdersQuery : IRequest<IEnumerable<Order>>
    {
        public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, IEnumerable<Order>>
        {
            private readonly IOrdersService _orderService;

            public GetAllOrdersQueryHandler(IOrdersService orderService)
            {
                _orderService = orderService;
            }

            public Task<IEnumerable<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }

        }
    }
}
