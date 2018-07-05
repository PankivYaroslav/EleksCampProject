using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GamesPortal.BL.DTOs;
using GamesPortal.BL.Services.Interfaces;
using GamesPortal.DAL.Entities;
using GamesPortal.DAL.Repositories.Interfaces;

namespace GamesPortal.BL.Services
{
    public class UserService : IBusinessLogic<UserDto>
    {
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;

        public UserService(IRepository<User> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var result = await _repository.GetAll();
            var dtos = _mapper.Map<IEnumerable<UserDto>>(result);
            return dtos;
        }

        public async Task<UserDto> Get(int id)
        {
            var result = await _repository.Get(id);
            var dto = _mapper.Map<UserDto>(result);
            return dto;
        }

        public async Task<UserDto> Create(UserDto entity)
        {
            var map = _mapper.Map<User>(entity);
            var result = await _repository.Create(map);
            var dto = _mapper.Map<UserDto>(result);
            return dto;
        }

        public async Task<UserDto> Update(UserDto entity)
        {
            var map = _mapper.Map<User>(entity);
            var result = await _repository.Update(map);
            var dto = _mapper.Map<UserDto>(result);
            return dto;
        }

        public async Task Delete(UserDto entity)
        {
            var map = _mapper.Map<User>(entity);
            await _repository.Delete(map);
        }
    }
}
