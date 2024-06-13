using System.Collections.Generic;
using System.Threading.Tasks;

namespace Zenzero.Core.Contracts
{
    public interface IService<T> where T : class, IEntity
    {
        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);
    }
}
