using PresentShop.Core.Entities;
using PresentShop.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Infrastructure.Repositories
{
    public class CartRepository : ICartRepository
    {
        public Task CreateAsync(Cart entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cart>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Cart>> GetByDateRangeAsync(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Task<Cart?> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Cart> GetCartByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Cart entity)
        {
            throw new NotImplementedException();
        }
    }
}
