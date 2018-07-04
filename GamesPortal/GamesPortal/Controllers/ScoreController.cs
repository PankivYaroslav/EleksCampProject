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
    [Route("api/Score")]
    public class ScoreController : BaseController<ScoreDto>
    {
        private readonly IBusinessLogic<ScoreDto> _businessLogic;

        public ScoreController(IBusinessLogic<ScoreDto> businessLogic)
        {
            _businessLogic = businessLogic;
        }

        public override Task<IActionResult> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Task<IActionResult> Get(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<IActionResult> Create(ScoreDto dto)
        {
            throw new NotImplementedException();
        }

        public override Task<IActionResult> Update(ScoreDto dto)
        {
            throw new NotImplementedException();
        }

        public override Task<IActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}