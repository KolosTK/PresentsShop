using Microsoft.EntityFrameworkCore;
using PresentShop.Core.Entities;
using PresentShop.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly PresentShopDbContext _dbContext;
        public ItemRepository(PresentShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateItemAsync(Item entity)
        {
            await _dbContext.Items.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Item>> GetAllAsync()
        {
            return await _dbContext.Items.Include(item=>item.Category).ToListAsync();
        }

        public async Task<Item?> GetByIdAsync(int id)
        {
           return await _dbContext.Items.Include(item => item.Category).FirstOrDefaultAsync(item=>item.Id==id);
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
