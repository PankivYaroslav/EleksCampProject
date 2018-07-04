using System.Collections.Generic;
using System.Threading.Tasks;
using GamesPortal.BL.DTOs;
using GamesPortal.BL.Services.Interfaces;
using GamesPortal.DAL.Repositories.Interfaces;

namespace GamesPortal.BL.Services
{
    public class UserService : IBusinessLogic<UserDto>
    {
        private readonly IRepository<UserDto> _repository;

        public UserService(IRepository<UserDto> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var result = await _repository.GetAll();
            return result;
        }

        public async Task<UserDto> Get(int id)
        {
            var result = await _repository.Get(id);
            return result;
        }

        public async Task<UserDto> Create(UserDto entity)
        {
            var result = await _repository.Create(entity);
            return result;
        }

        public async Task<UserDto> Update(UserDto entity)
        {
            var result = await _repository.Update(entity);
            return result;
        }

        public async Task Delete(UserDto entity)
        {
            await _repository.Delete(entity);
        }
    }
}
