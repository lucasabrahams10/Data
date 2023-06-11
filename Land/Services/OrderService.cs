using LandLord.Contexts;
using LandLord.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LandLord.Services;

internal class OrderService
{
    private readonly DataContext _context = new();

    public async Task CreateOrderAsync(OrderEntity entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<OrderEntity>> GetAllOrdersAsync()
    {
        var item = await _context.Orders
                    .Include(x => x.Tenant).ThenInclude(t => t.Apartment)
                    .Include(x => x.Tenant).ThenInclude(t => t.Person)
                    .ToListAsync();

        if (item != null)
            return item;

        return null!;

    }

    public async Task<OrderEntity> GetOrderAsync(Expression<Func<OrderEntity, bool>> predicate)
    {
        var _entity = await _context.Orders
            .Include(x => x.OrderRows)
                .ThenInclude(o => o.StatusCode)
            .Include(x => x.Tenant)
                .ThenInclude(t => t.Apartment)
            .Include(x => x.Tenant)
                .ThenInclude(t => t.Person)
                .ThenInclude(p => p.Comment)
                .FirstOrDefaultAsync(predicate);

        if(_entity != null)
            return _entity!;

        return null!;
    }

    internal Task CreateOrderAsync()
    {
        throw new NotImplementedException();
    }
}