using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers {
    [Route ("api/[controller")]
    [ApiController]
    public class AuthController : ControllerBase {
        private readonly IAuthRepository _repo;
        public AuthController (IAuthRepository repo) {
            _repo = repo;

        }

        [HttpPost]
        public async Task<IActionResult> Register (string username, string password) {
            //validate the request

            username = username.ToLower ();
            if (!await _repo.UserExists(username))
                return BadRequest ("Username not exists");
var userToCreate = new User{
    Username=username;

}


        }
    }
}