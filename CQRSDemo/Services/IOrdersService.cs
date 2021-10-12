using CQRSDemo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSDemo.Services
{
    public interface IOrdersService
    {
        Task<IEnumerable<Order>> GetOrdersList();
        Task<Order> GetOrderById(int orderId);
    }
}
