using PresentShop.Core.DTOs;
using PresentShop.Core.Entities;
using PresentShop.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Core.Interfaces.IServices
{
    public interface IOrderService
    {
        Task<OrderDTO> GetOrderByIdAsync(int id);
        Task<List<OrderDTO>> GetOrdersByDateRateAsync(DateTime? startDate, DateTime? endDate);
        Task<List<OrderDTO>> GetOrdersByStatusAsync (OrderStatus status);
        Task<List<OrderDTO>> GetOrdersByTotalPriceAsync(decimal minPrice, decimal maxPrice);
        Task<List<OrderDTO>> GetOrdersByUserIdAsync(string userId);
        Task CreateOrderAsync(string userId, int cartId);

    }
}
