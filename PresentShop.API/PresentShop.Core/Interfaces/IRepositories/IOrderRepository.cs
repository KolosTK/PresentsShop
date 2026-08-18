using PresentShop.Core.Entities;
using PresentShop.Core.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PresentShop.Infrastructure.Repositories
{
    public interface IOrderRepository:IRepository<Order>
    {
        Task<List<Order>> GetOrdersByUserIdAsync(string userId);
        Task<List<Order>> GetOrdersByDataRangeAsync(DateTime start, DateTime end);
        Task<List<Order>> GetOrdersByPriceRangeAsync(decimal min, decimal max);
        Task<List<Order>> GetOrdersByStatus(OrderStatus status);
    }
}
