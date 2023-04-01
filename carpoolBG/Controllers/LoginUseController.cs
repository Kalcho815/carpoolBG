using carpoolBG.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace carpoolBG.Controllers
{
    [Route("user/[controller]")]
    [ApiController]
    public class LoginUseController : ControllerBase
    {
        private readonly SignInManager<CarpoolUser> _signInManager;

        public LoginUseController(SignInManager<CarpoolUser> signInManager)
        {
            this._signInManager = signInManager;
        }

        [HttpPost(Name = "PostLoginUser")]
        public async Task<Microsoft.AspNetCore.Identity.SignInResult> Post()
        {
            var testUser = new CarpoolUser
            {
                UserName = "FirstTest"
                ,
                Email = "FirstEmailTest"
                ,
                FirstName = "Ivan"
                ,
                LastName = "Ivanov"
                ,
                Sex = Models.Enums.Sex.Male
                ,
                UserType = Models.Enums.UserType.Passenger
            };

            var result = await _signInManager.PasswordSignInAsync(testUser.UserName, "Ttestuser123!", false, lockoutOnFailure: false);

            return result;
        }

    }
}
