using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesPortal.BL.DTOs;
using GamesPortal.BL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamesPortal.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : BaseController<UserDto>
    {
        private readonly IBusinessLogic<UserDto> _businessLogic;

        public UserController(IBusinessLogic<UserDto> businessLogic)
        {
            _businessLogic = businessLogic;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAllAsync()
        {
            var dtoList = await _businessLogic.GetAll();
            return Ok(dtoList);
        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(int id)
        {
            var record = await _businessLogic.Get(id);
            return Ok(record);
        }

        [HttpPost]
        public override async Task<IActionResult> CreateAsync([FromBody]UserDto dto)
        {
            var record = await _businessLogic.Create(dto);
            return Ok(record);
        }

        [HttpPut]
        public override async Task<IActionResult> UpdateAsync([FromBody]UserDto dto)
        {
            var record = await _businessLogic.Update(dto);
            return Ok(record);
        }

        [HttpDelete]
        public override async Task<IActionResult> DeleteAsync([FromBody]UserDto dto)
        {
            await _businessLogic.Delete(dto);
            return Ok();
        }
    }
}