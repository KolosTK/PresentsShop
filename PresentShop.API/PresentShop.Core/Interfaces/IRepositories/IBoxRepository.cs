using PresentShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Infrastructure.Repositories
{
    public interface IBoxRepository : IRepository<Box>
    {
        Task<List<Box>> GetBoxItemsAsync(int boxId);
        Task<Box> GetBoxByUserId (string userId);

    }
}
