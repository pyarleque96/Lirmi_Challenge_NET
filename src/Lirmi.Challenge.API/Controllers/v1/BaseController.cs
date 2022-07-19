using Microsoft.AspNetCore.Mvc;

namespace Lirmi.Challenge.API.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]/[action]")]
    public class BaseController : ControllerBase
    {
        public BaseController()
        {
        }
    }
}
