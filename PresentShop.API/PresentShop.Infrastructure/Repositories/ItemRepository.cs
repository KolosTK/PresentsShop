using PresentShop.Core.Entities;
using PresentShop.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        public Task CreateAsync(Item entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Item>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Item?> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Item>> GetItemsByCategoryIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Item>> GetItemsByPriceRangeAsync(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Item entity)
        {
            throw new NotImplementedException();
        }
    }
}
