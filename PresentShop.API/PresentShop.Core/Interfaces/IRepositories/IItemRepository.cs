using PresentShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Infrastructure.IRepositories
{
    public interface IItemRepository : IRepository<Item>
    {
        Task<List<Item>> GetItemsByPriceRangeAsync(decimal min, decimal max);
        Task<List<Item>> GetItemsByCategoryIdAsync(int categoryId);
    }
}
