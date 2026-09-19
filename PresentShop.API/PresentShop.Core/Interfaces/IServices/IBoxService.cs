using PresentShop.Core.DTOs;
using PresentShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Core.Interfaces.IServices
{
    public interface IBoxService
    {
        Task<BoxDTO> GetBoxByIdAsync(int id);
        Task CreateBoxAsync (CreateBoxDTO box);
        Task UpdateBoxAsync(int id,UpdateBoxDTO box);
        Task DeleteBoxAsync(int boxId);

        Task AddItemAsync(int boxId, BoxItemDTO item);
        Task UpdateItemBoxAsync(int boxId, BoxItemDTO item);
        Task RemoveItemFromBoxAsync(int boxId, int itemId);

        Task<List<BoxDTO>> GetAllBoxesAsync();
        Task<List<BoxDTO>> GetUserBoxesAsync(string userId);
        Task<BoxDTO> CopyBoxFromExestedAsync(int boxId, string userId);
    }
}
