using CQRSDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.Services
{
    public interface IOrdersService
    {
        Task<IEnumerable<Order>> GetOrdersList();
    }
}
