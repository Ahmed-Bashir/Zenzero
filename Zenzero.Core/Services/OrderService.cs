using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zenzero.Core.Contracts;
using Zenzero.Core.Models;
using Zenzero.Core.Persistence;


namespace Zenzero.Core.Services
{
    public sealed class OrderService : IOrderService
    {
        private readonly ZenzeroContext _context;

        public OrderService(ZenzeroContext context) => _context = context;

        public async Task<Order> AddAsync(Order entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Order> CancelAsync(Order entity)
        {
            entity.IsActive = false;
            await UpdateAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<Order>> GetAllAsync() => await _context.Orders.ToListAsync();

        public async Task<Order> GetByIdAsync(int id) => await _context.Orders.FindAsync(id);

        public async Task<IEnumerable<Order>> GetSelectionAsync(bool isActive) =>
            await _context.Orders.Where(x => x.IsActive == isActive).ToListAsync();

        public async Task<Order> UpdateAsync(Order entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
