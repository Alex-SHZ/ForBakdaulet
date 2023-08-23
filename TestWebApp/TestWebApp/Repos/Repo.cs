using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TestWebApp.Data;
using TestWebApp.Model;

namespace TestWebApp.Repos;

public class Repo : IRepo
{
    private readonly AppDbContext _db;

    public Repo(AppDbContext db)
    {
        _db = db;
    }
    
    public async Task<IEnumerable<T>> Get<T>(int id, Expression<Func<TestClass,T>> selector, int id2 = 0) where T : class
    {
        return await _db.TestClasses
            .Where(x => x.Id == id)
            .Select(selector)
            .ToArrayAsync();
    }
    
    public async Task<IEnumerable<T>> GetByAge<T>(int age, Expression<Func<TestClass,T>> selector, int id2 = 0) where T : class
    {
        return await _db.TestClasses
            .Where(x => x.Age == age)
            .Select(selector)
            .ToArrayAsync();
    }
}