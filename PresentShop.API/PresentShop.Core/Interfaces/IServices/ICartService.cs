using PresentShop.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Core.Interfaces.IServices
{
    public interface ICartService
    {
        Task<CartDTO> GetCartByIdAsync(int id);
        Task DeleteCartAsync(int id);
        Task AddBoxToCartAsync(int cartId, int boxId);
        Task RemoveBoxFromCartAsync(int cartId, int boxId);
        Task ClearCartAsync (int cartId);
        Task <CartDTO> GetActiveCartByUserIdAsync(int userId);
    }
}
