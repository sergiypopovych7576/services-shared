using System;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Shared.Services.Repositories
{
    public interface IReadRepository<T>
    {
        IQueryable<T> Get();
        ValueTask<T> FindAsync(Guid id);
    }
}
