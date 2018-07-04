using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GamesPortal.Api.Controllers
{
    public abstract class BaseController<T> : Controller
    {
        public abstract Task<IActionResult> GetAll();
        public abstract Task<IActionResult> Get([FromRoute]int id);
        public abstract Task<IActionResult> Create([FromBody]T dto);
        public abstract Task<IActionResult> Update([FromBody]T dto);
        public abstract Task<IActionResult> Delete([FromRoute]int id);
    }
}