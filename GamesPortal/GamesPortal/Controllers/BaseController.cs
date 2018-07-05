using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GamesPortal.Api.Controllers
{
    public abstract class BaseController<T> : Controller
    {
        public abstract Task<IActionResult> GetAllAsync();
        public abstract Task<IActionResult> GetAsync([FromRoute]int id);
        public abstract Task<IActionResult> CreateAsync([FromBody]T dto);
        public abstract Task<IActionResult> UpdateAsync([FromBody]T dto);
        public abstract Task<IActionResult> DeleteAsync([FromBody]T dto);
    }
}