using System.Collections.Generic;
using System.Threading.Tasks;
using Zenzero.Core.Models;

namespace Zenzero.Core.Contracts
{
    public interface IOrderService : IService<Order>
    {
        Task<IEnumerable<Order>> GetSelectionAsync(bool isActive);

        Task<Order> CancelAsync(Order entity);
    }
}
