using PresentShop.Core.Entities;
using PresentShop.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Infrastructure.Repositories
{
    public class BoxRepository : IBoxRepository
    {
        public Task CreateAsync(Box entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Box>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Box> GetBoxByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Box>> GetBoxItemsAsync(int boxId)
        {
            throw new NotImplementedException();
        }

        public Task<Box?> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Box entity)
        {
            throw new NotImplementedException();
        }
    }
}
