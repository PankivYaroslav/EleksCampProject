using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GamesPortal.BL.DTOs;
using GamesPortal.BL.Services.Interfaces;
using GamesPortal.DAL.Entities;
using GamesPortal.DAL.Repositories.Interfaces;

namespace GamesPortal.BL.Services
{
    public class GameService : IBusinessLogic<GameDto>
    {
        private readonly IRepository<Game> _repository;
        private readonly IMapper _mapper;

        public GameService(IRepository<Game> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GameDto>> GetAll()
        {
            var result = await _repository.GetAll();
            var dtos = _mapper.Map<IEnumerable<GameDto>>(result);
            return dtos;
        }

        public async Task<GameDto> Get(int id)
        {
            var result = await _repository.Get(id);
            var dto = _mapper.Map<GameDto>(result);
            return dto;
        }

        public async Task<GameDto> Create(GameDto entity)
        {
            var map = _mapper.Map<Game>(entity);
            var result = await _repository.Create(map);
            var dto = _mapper.Map<GameDto>(result);
            return dto;
        }

        public async Task<GameDto> Update(GameDto entity)
        {
            var map = _mapper.Map<Game>(entity);
            var result = await _repository.Update(map);
            var dto = _mapper.Map<GameDto>(result);
            return dto;
        }

        public async Task Delete(GameDto entity)
        {
            var map = _mapper.Map<Game>(entity);
            await _repository.Delete(map);
        }
    }
}
