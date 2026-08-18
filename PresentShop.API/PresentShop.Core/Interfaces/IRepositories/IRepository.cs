using System;
using System.Collections.Generic;
using System.Text;

namespace PresentShop.Infrastructure.IRepositories
{
    public interface IRepository<T> where T: class
    {
         Task<List<T>> GetAllAsync();
         Task<T?> GetByIdAsync(int Id);
         Task DeleteById(int Id);
         Task Update(T entity);
         Task Create(T entity);
    }
}
