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
    [Route("api/Game")]
    public class GameController : BaseController<GameDto>
    {
        private readonly IBusinessLogic<GameDto> _businessLogic;

        public GameController(IBusinessLogic<GameDto> businessLogic)
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

        public override Task<IActionResult> Create(GameDto dto)
        {
            throw new NotImplementedException();
        }

        public override Task<IActionResult> Update(GameDto dto)
        {
            throw new NotImplementedException();
        }

        public override Task<IActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}