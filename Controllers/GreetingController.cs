using Microsoft.AspNetCore.Mvc;

namespace testWebapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreetingController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hey whats up? This is a new API. Maybe we'll using c# for the backend now. Yuhu";
        }
    }
}
