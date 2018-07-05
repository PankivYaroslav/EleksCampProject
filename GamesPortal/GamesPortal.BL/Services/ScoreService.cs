using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GamesPortal.BL.DTOs;
using GamesPortal.BL.Services.Interfaces;
using GamesPortal.DAL.Entities;
using GamesPortal.DAL.Repositories.Interfaces;

namespace GamesPortal.BL.Services
{
    public class ScoreService : IBusinessLogic<ScoreDto>
    {
        private readonly IRepository<Score> _repository;
        private readonly IMapper _mapper;

        public ScoreService(IRepository<Score> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ScoreDto>> GetAll()
        {
            var result = await _repository.GetAll();
            var dtos = _mapper.Map<IEnumerable<ScoreDto>>(result);
            return dtos;
        }

        public async Task<ScoreDto> Get(int id)
        {
            var result = await _repository.Get(id);
            var dto = _mapper.Map<ScoreDto>(result);
            return dto;
        }

        public async Task<ScoreDto> Create(ScoreDto entity)
        {
            var map = _mapper.Map<Score>(entity);
            var result = await _repository.Create(map);
            var dto = _mapper.Map<ScoreDto>(result);
            return dto;
        }

        public async Task<ScoreDto> Update(ScoreDto entity)
        {
            var map = _mapper.Map<Score>(entity);
            var result = await _repository.Update(map);
            var dto = _mapper.Map<ScoreDto>(result);
            return dto;
        }

        public async Task Delete(ScoreDto entity)
        {
            var map = _mapper.Map<Score>(entity);
            await _repository.Delete(map);
        }
    }
}
