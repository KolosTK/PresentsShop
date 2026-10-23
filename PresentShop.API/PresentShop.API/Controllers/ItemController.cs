using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PresentShop.Core.DTOs;
using PresentShop.Core.Interfaces.IServices;

namespace PresentShop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ItemDTO>>> GetAll()
        {
            List<ItemDTO> items = await _itemService.GetAllItemsAsync();
            return items;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ItemDTO>> GetById(int id)
        {
            ItemDTO? item = await _itemService.GetItemByIdAsync(id);

            return item == null ? NotFound() : item;
        }

        [HttpGet("category/{categoryId}")]
        public async Task<ActionResult<List<ItemDTO>>> GetByCategoryId(int categoryId)
        {
            List<ItemDTO> items = await _itemService.GetItemsByCategoryAsync(categoryId);
            return items;
        }

        //api/item/price?min=5&max=10
        [HttpGet("price")]
        public async Task<ActionResult<List<ItemDTO>>> GetByPriceRange(decimal min, decimal max)
        {
            List<ItemDTO> items = await _itemService.GetItemsByPriceRangeAsync(min, max);
            return items;
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(CreateItemDTO createItemDTO)
        {
            await _itemService.CreateItemAsync(createItemDTO);
            return Ok();
        }
    }
    
}
