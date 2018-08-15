//***** This API Controller will return a Json list of 
// all previous requests in the Get AcionResult method *****//

using Clockwork.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clockwork.API.Controllers
{
    [Route("api/[controller]")]
    public class ListPreviousRequestsController : Controller
    {
        private ClockworkContext clockwork = new ClockworkContext();

        // GET api/listpreviousrequests
        [HttpGet]
        public IActionResult Get()
        {
            return Json(clockwork.CurrentTimeQueries.ToList());
        }
    }
}
