using LandLord.Contexts;
using LandLord.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LandLord.Services;

internal class OrderRowService
{
    private readonly DataContext _context = new();

    public async Task CreateOrderRowAsync(OrderRowEntity entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<OrderRowEntity>> GetAllActiveOrderRowsAsync()
    {
        var item = await _context.OrderRows
                    .Include(x => x.StatusCode).Where(x => x.Id != 4)
                    .ToListAsync();

        if (item != null)
            return item;

        return null!;

    }

    public async Task UpdateStatusCode(int orderRowId, int statusId)
    {
        var _entity = await _context.OrderRows.FindAsync(orderRowId);
        if (_entity != null) 
        {
            _entity.UpdateAt = DateTime.UtcNow;
            _entity.StatusId = statusId;
            _context.Update(_entity);
            await _context.SaveChangesAsync();
        }
    }

    public async Task CreateComment(CommentEntity comment)
    {
        await _context.AddAsync(comment);
        await _context.SaveChangesAsync();
        await UpdateStatusCode(comment.OrderRowId, 2);
    }
}