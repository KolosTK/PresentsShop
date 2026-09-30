using PresentShop.Core.Entities;
using PresentShop.Core.Enums;
using PresentShop.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task CreateAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Order?> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetOrdersByDataRangeAsync(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetOrdersByPriceRangeAsync(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetOrdersByStatus(OrderStatus status)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetOrdersByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
