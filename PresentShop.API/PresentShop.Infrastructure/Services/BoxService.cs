using PresentShop.Core.DTOs;
using PresentShop.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Infrastructure.Services
{
    public class BoxService : IBoxService
    {
        public Task AddItemAsync(int boxId, BoxItemDTO item)
        {
            throw new NotImplementedException();
        }

        public Task<BoxDTO> CopyBoxFromExestedAsync(int boxId, string userId)
        {
            throw new NotImplementedException();
        }

        public Task CreateBoxAsync(CreateBoxDTO box)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBoxAsync(int boxId)
        {
            throw new NotImplementedException();
        }

        public Task<List<BoxDTO>> GetAllBoxesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BoxDTO> GetBoxByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BoxDTO>> GetUserBoxesAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveItemFromBoxAsync(int boxId, int itemId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBoxAsync(int id, UpdateBoxDTO box)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItemBoxAsync(int boxId, BoxItemDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
