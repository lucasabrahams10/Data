using LandLord.Contexts;
using LandLord.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LandLord.Services;

internal class PersonService
{
    private readonly DataContext _context = new();

    public async Task<PersonEntity> GetAPersonAsync(Expression<Func<PersonEntity, bool>> predicate)
    {
       var _entity = await _context.Persons.FirstOrDefaultAsync(predicate);

        if (_entity == null) 
        {
            Console.WriteLine($"Den person du söker efter med detta värde {predicate} finns inte i databasen.");
        }

        return _entity!;
    }

    public async Task<IEnumerable<PersonEntity>> GetAllPersonsAsync()
    {
        return await _context.Persons.ToListAsync();
    }
}