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
        public async Task<IdentityResult> Post([FromQuery] string username, string email, string firstName, string lastName, string sex, string userType, DateOnly dateOfBirth
            , [FromBody] string password)
        {
            var testUser = new CarpoolUser
            {
                UserName = username
                , Email = email
                , FirstName = firstName
                , LastName = lastName
                , Sex = Models.Enums.Sex.Male
                , UserType = Models.Enums.UserType.Passenger
                , DateOfBirth = DateTime.Parse(dateOfBirth.ToString())
            };

            var result = await userManager.CreateAsync(testUser, password);

            return result;
        }

    }
}
