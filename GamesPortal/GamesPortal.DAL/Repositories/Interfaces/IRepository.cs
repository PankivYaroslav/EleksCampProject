using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesPortal.DAL.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
    }
}
