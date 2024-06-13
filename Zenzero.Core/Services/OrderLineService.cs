using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zenzero.Core.Contracts;
using Zenzero.Core.Models;
using Zenzero.Core.Persistence;

namespace Zenzero.Core.Services
{
    public sealed class OrderLineService : IOrderLineService
    {
        private readonly ZenzeroContext _context;

        public OrderLineService(ZenzeroContext context) => _context = context;

        public async Task<OrderLine> AddAsync(OrderLine entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async void DeleteAsync(OrderLine entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<OrderLine>> GetAllAsync() => await _context.OrderLines.ToListAsync();

        public async Task<OrderLine> GetByIdAsync(int id) => await _context.OrderLines.FindAsync(id);

        public async Task<OrderLine> UpdateAsync(OrderLine entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
