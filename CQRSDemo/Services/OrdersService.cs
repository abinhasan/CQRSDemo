using CQRSDemo.DataContext;
using CQRSDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly DatabaseContext _context;

        public OrdersService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order>> GetOrdersList()
        {
            return await _context.Order
                .ToListAsync();
        }
    }
}
