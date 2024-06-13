using System.Collections.Generic;
using System.Threading.Tasks;
using Zenzero.Core.Models;

namespace Zenzero.Core.Contracts
{
    public interface IService<T> where T : class, IEntity
    {
        Task<Order> AddAsync(T entity);

        Task<Order> UpdateAsync(T entity);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);
    }
}
