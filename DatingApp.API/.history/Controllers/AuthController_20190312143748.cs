using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class AuthController:ControllerBase
    {
        public AuthController(IAuthRepository repo)
        {
            
        }
    }
}