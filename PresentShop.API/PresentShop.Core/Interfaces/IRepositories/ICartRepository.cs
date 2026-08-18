using PresentShop.Core.Entities;
using PresentShop.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Infrastructure.Repositories
{
    public interface ICartRepository : IRepository<Cart>
    {
        Task<List<Cart>> GetByDateRangeAsync(DateTime start, DateTime end);
        Task<Cart> GetCartByUserId(string userId);
    }
}
