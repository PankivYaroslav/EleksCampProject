using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesPortal.BL.Services.Interfaces
{
    public interface IBusinessLogic<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
    }
}
