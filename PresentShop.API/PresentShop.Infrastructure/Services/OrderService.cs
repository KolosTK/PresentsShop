using PresentShop.Core.DTOs;
using PresentShop.Core.Enums;
using PresentShop.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        public Task CreateOrderAsync(string userId, int cartId)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDTO> GetOrderByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDTO>> GetOrdersByDateRateAsync(DateTime? startDate, DateTime? endDate)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDTO>> GetOrdersByStatusAsync(OrderStatus status)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDTO>> GetOrdersByTotalPriceAsync(decimal minPrice, decimal maxPrice)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDTO>> GetOrdersByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
