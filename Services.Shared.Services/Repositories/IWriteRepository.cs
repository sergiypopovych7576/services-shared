using System;
using System.Threading.Tasks;

namespace Services.Shared.Services.Repositories
{
    public interface IWriteRepository<T>
    {
        ValueTask<T> Create(T entity);
        ValueTask<T> Update(T entity);
        ValueTask Delete(Guid id);
    }
}
