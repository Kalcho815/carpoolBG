using carpoolBG.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace carpoolBG.Controllers
{
    [Route("user/[controller]")]
    [ApiController]
    public class LoginUserController : ControllerBase
    {
        private readonly SignInManager<CarpoolUser> _signInManager;

        public LoginUserController(SignInManager<CarpoolUser> signInManager)
        {
            this._signInManager = signInManager;
        }

        [HttpPost(Name = "PostLoginUser")]
        public async Task<Microsoft.AspNetCore.Identity.SignInResult> Post([FromQuery] string username, [FromBody] string password)
        {
            var result = await _signInManager.PasswordSignInAsync(username, password, false, lockoutOnFailure: false);

            return result;
        }

    }
}
