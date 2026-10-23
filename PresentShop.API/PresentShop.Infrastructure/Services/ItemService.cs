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

    
        public async Task CreateItemAsync(CreateItemDTO createItemDTO)
        {
            await _itemRepository.CreateItemAsync(new Item
            {
                Name = createItemDTO.Name,
                Length = createItemDTO.Length,
                Width = createItemDTO.Width,
                Height = createItemDTO.Height,
                Description = createItemDTO.Description,
                Price = createItemDTO.Price,
                CategoryId = createItemDTO.CategoryId,
                ImageURL = createItemDTO.ImageURL
            });
        }


        public async Task<List<ItemDTO>> GetAllItemsAsync()
        {
            List<Item>  items = await _itemRepository.GetAllAsync();

            return items.Select(MapToDto).ToList();
        }

        public async Task<ItemDTO?> GetItemByIdAsync(int id)
        {
           
            Item? item = await _itemRepository.GetByIdAsync(id);
            if (item == null) return null;
            return MapToDto(item);
        }

        public async Task<List<ItemDTO>> GetItemsByCategoryAsync(int categoryId)
        {
            List<Item> items = await _itemRepository.GetItemsByCategoryIdAsync(categoryId);
            return items.Select(MapToDto).ToList();
        }
        public async Task<List<ItemDTO>> GetItemsByPriceRangeAsync(decimal min, decimal max)
        {
            List<Item> items = await _itemRepository.GetItemsByPriceRangeAsync(min, max);
            return items.Select(MapToDto).ToList();
        }
        public Task DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        

        public Task UpdateItemAsync(int updatedItemId, UpdateItemDTO item)
        {
            throw new NotImplementedException();
        }


        private static ItemDTO MapToDto(Item item)
        {
            return new ItemDTO
            {
                Id = item.Id,
                Name = item.Name,
                Length = item.Length,
                Width = item.Width,
                Height = item.Height,
                Description = item.Description,
                Price = item.Price,
                CategoryName = item.Category.Name,
                ImageURL = item.ImageURL
            };
        }
    }
}
