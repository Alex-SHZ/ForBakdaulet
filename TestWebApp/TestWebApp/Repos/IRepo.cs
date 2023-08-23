using System.Linq.Expressions;
using TestWebApp.Model;

namespace TestWebApp.Repos;

public interface IRepo
{
    Task<IEnumerable<T>> Get<T>(int id, Expression<Func<TestClass, T>> selector, int id2 = 0) where T : class;
    Task<IEnumerable<T>> GetByAge<T>(int age, Expression<Func<TestClass, T>> selector, int id2 = 0) where T : class;
}