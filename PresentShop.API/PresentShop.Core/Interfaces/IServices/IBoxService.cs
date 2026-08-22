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
        Task UpdateBoxAsync(int id,UpdateBoxDTO box);
        Task AddItemAsync(int boxId, AddItemToBoxDTO item);
        Task RemoveItemFromBoxAsync(int id);
        Task CreateBoxAsync (CreateBoxDTO box);
        Task DeleteBoxAsync(int id);
        Task<List<BoxDTO>> GetAllBoxesAsync();
        Task<List<BoxDTO>> GetUserBoxesAsync(string id);
        Task<BoxDTO> CopyBoxFromExestedAsync(int Boxid, string userId);
    }
}
