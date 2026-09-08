using System;
using System.Collections.Generic;
using PresentShop.Core.DTOs;
using System.Text;

namespace PresentShop.Core.Interfaces.IServices
{
    public interface IItemService
    {
        Task<ItemDTO> GetItemByIdAsync(int id);
        Task<List<ItemDTO>> GetAllItemsAsync();
        Task<List<ItemDTO>> GetItemsByPriceRangeAsync(decimal min, decimal max);
        Task<List<ItemDTO>> GetItemsByCategoryAsync(int categoryId);
        Task CreateItemAsync(CreateItemDTO item);
        Task UpdateItemAsync(int updatedItemId, UpdateItemDTO item);
        Task DeleteItemAsync(int id);
    }
}
