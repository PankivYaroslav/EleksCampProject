using System.Collections.Generic;
using System.Threading.Tasks;
using GamesPortal.BL.DTOs;
using GamesPortal.BL.Services.Interfaces;
using GamesPortal.DAL.Repositories.Interfaces;

namespace GamesPortal.BL.Services
{
    public class ScoreService : IBusinessLogic<ScoreDto>
    {
        private readonly IRepository<ScoreDto> _repository;

        public ScoreService(IRepository<ScoreDto> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ScoreDto>> GetAll()
        {
            var result = await _repository.GetAll();
            return result;
        }

        public async Task<ScoreDto> Get(int id)
        {
            var result = await _repository.Get(id);
            return result;
        }

        public async Task<ScoreDto> Create(ScoreDto entity)
        {
            var result = await _repository.Create(entity);
            return result;
        }

        public async Task<ScoreDto> Update(ScoreDto entity)
        {
            var result = await _repository.Update(entity);
            return result;
        }

        public async Task Delete(ScoreDto entity)
        {
            await _repository.Delete(entity);
        }
    }
}
