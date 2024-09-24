using Microsoft.AspNetCore.Mvc;

namespace eTutor.Server.Controllers
{
    //[ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
       
    }
}
