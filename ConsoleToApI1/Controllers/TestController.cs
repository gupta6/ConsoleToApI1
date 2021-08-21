using Microsoft.AspNetCore.Mvc;

namespace ConsoleToAPI1.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    // [Route("test")]
    public class TestController: ControllerBase
    {
        public string Get()
        {
            return "Hello From Get";
        }

        public string Get1()
        {
            return "Hello From Get";
        }
    }
}