using System.Collections.Generic;
using System.Threading.Tasks;
using GamesPortal.BL.DTOs;
using GamesPortal.BL.Services.Interfaces;
using GamesPortal.DAL.Entities;
using GamesPortal.DAL.Repositories.Interfaces;

namespace GamesPortal.BL.Services
{
    public class GameService : IBusinessLogic<GameDto>
    {
        private readonly IRepository<GameDto> _repository;

        public GameService(IRepository<GameDto> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GameDto>> GetAll()
        {
            var result = await _repository.GetAll();
            return result;
        }

        public async Task<GameDto> Get(int id)
        {
            var result = await _repository.Get(id);
            return result;
        }

        public async Task<GameDto> Create(GameDto entity)
        {
            var result = await _repository.Create(entity);
            return result;
        }

        public async Task<GameDto> Update(GameDto entity)
        {
            var result = await _repository.Update(entity);
            return result;
        }

        public async Task Delete(GameDto entity)
        {
            await _repository.Delete(entity);
        }
    }
}
