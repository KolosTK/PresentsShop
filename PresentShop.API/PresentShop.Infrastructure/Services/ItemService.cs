using PresentShop.Core.DTOs;
using PresentShop.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using PresentShop.Core.Interfaces.IRepositories;
using System.Text;
using PresentShop.Core.Entities;

namespace PresentShop.Infrastructure.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public Task CreateItemAsync(CreateItemDTO item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ItemDTO>> GetAllItemsAsync()
        {
            List<Item>  items = await _itemRepository.GetAllAsync();

            return items.Select(item=>new ItemDTO {
            Id= item.Id,
            Name= item.Name,
            Length= item.Length,
            Width= item.Width,
            Height= item.Height,
            Description= item.Description,
            Price= item.Price,
            CategoryName = item.Category.Name,
            ImageURL= item.ImageURL
            }).ToList();
        }

        public async Task<ItemDTO?> GetItemByIdAsync(int id)
        {
           
            Item? item = await _itemRepository.GetByIdAsync(id);
            if (item == null) return null;

            return new ItemDTO{
            Id = item.Id,
            Name= item.Name,
            Length= item.Length,
            Width= item.Width,
            Height= item.Height,
            Description= item.Description,
            Price= item.Price,
            CategoryName = item.Category.Name,
            ImageURL= item.ImageURL
            };
            
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
