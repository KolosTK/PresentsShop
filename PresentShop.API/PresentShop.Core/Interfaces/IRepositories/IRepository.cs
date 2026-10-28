using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Core.Interfaces.IRepositories
{
    public interface IRepository<T> where T: class
    {
         Task<List<T>> GetAllAsync();
         Task<T?> GetByIdAsync(int Id);
         Task<bool> DeleteByIdAsync(int Id);
         Task UpdateAsync(T entity);
         Task CreateItemAsync(T entity);
    }
}
