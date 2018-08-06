using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesPortal.BL.DTOs;
using GamesPortal.BL.Services.Interfaces;
using GamesPortal.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamesPortal.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Score")]
    public class ScoreController : BaseController<ScoreDto>
    {
        private readonly IBusinessLogic<ScoreDto> _businessLogic;

        public ScoreController(IBusinessLogic<ScoreDto> businessLogic)
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
        public override async Task<IActionResult> CreateAsync(ScoreDto dto)
        {
            var record = await _businessLogic.Create(dto);
            return Ok(record);
        }

        [HttpPut]
        public override async Task<IActionResult> UpdateAsync([FromBody]ScoreDto dto)
        {
            var record = await _businessLogic.Update(dto);
            return Ok(record);
        }

        [HttpDelete]
        public override async Task<IActionResult> DeleteAsync([FromBody]ScoreDto dto)
        {
            await _businessLogic.Delete(dto);
            return Ok();
        }
    }
}