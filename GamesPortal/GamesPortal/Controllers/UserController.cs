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

        public override Task<IActionResult> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Task<IActionResult> Get(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<IActionResult> Create(UserDto dto)
        {
            throw new NotImplementedException();
        }

        public override Task<IActionResult> Update(UserDto dto)
        {
            throw new NotImplementedException();
        }

        public override Task<IActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}