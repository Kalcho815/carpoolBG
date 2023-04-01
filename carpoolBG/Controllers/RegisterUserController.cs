using carpoolBG.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace carpoolBG.Controllers
{
    [Route("user/[controller]")]
    [ApiController]
    public class RegisterUserController : ControllerBase
    {
        private readonly UserManager<CarpoolUser> userManager;

        public RegisterUserController(UserManager<CarpoolUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpPost(Name = "PostRegisterUser")]
        public async Task<IdentityResult> Post()
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

            var result = await userManager.CreateAsync(testUser, "Ttestuser123!");

            return result;
        }

    }
}
