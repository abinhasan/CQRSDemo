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

        public async Task<Order> GetOrderById(int orderId)
        {
            return await _context.Order
                .FirstOrDefaultAsync(x => x.OrderId == orderId);
        }

        public async Task<Order> CreateOrder(Order order)
        {
            _context.Order.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }
    }
}
