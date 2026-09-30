using PresentShop.Core.DTOs;
using PresentShop.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Infrastructure.Services
{
    public class ItemService : IItemService
    {
        public Task CreateItemAsync(CreateItemDTO item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemDTO>> GetAllItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ItemDTO> GetItemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemDTO>> GetItemsByCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemDTO>> GetItemsByPriceRangeAsync(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItemAsync(int updatedItemId, UpdateItemDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
