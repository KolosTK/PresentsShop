using PresentShop.Core.DTOs;
using PresentShop.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Infrastructure.Services
{
    public class CartService : ICartService
    {
        public Task AddBoxToCartAsync(int cartId, int boxId)
        {
            throw new NotImplementedException();
        }

        public Task ClearCartAsync(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCartAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CartDTO> GetActiveCartByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<CartDTO> GetCartByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveBoxFromCartAsync(int cartId, int boxId)
        {
            throw new NotImplementedException();
        }
    }
}
