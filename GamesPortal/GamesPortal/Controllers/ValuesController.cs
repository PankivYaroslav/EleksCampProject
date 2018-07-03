using System.Collections.Generic;
using GamesPortal.DAL.Entities;
using GamesPortal.DAL.Repositories;
using GamesPortal.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GamesPortal.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IRepository<User> _repository;

        public ValuesController(IRepository<User> repository)
        {
            _repository = repository;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _repository.Create(new User()
            {
                Id = 1,
                FirstName = "qwe",
                LastName = "asd",
                UserName = "qweasd",
                Email = "qwe@gmail.com",
                PassWord = "pass"
            });
            _repository.GetAll();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
