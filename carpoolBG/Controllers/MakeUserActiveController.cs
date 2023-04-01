using carpoolBG.Data;
using carpoolBG.Models;
using carpoolBG.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace carpoolBG.Controllers
{
    [Route("user/[controller]")]
    [ApiController]
    public class MakeUserActiveController : ControllerBase
    {
        private readonly IHttpContextAccessor httpContext;
        private readonly CarpoolContext dbContext;
        private readonly string? username;
        private CarpoolUser user;
        UserService userService;

        public MakeUserActiveController(IHttpContextAccessor httpContext, CarpoolContext dbContext, UserService userService)
        {
            this.httpContext = httpContext;
            this.dbContext = dbContext;
            this.userService = userService;
            this.username = httpContext.HttpContext.User.Identity.Name;

            if (username != null)
            {
                this.user = dbContext.Users
                    .Where(u => u.UserName == username)
                    .FirstOrDefault();
            }
        }

        [HttpPost(Name = "MakeUserActive")]
        public string Get()
        {
            string result = null;

            if (user != null)
            {
                result = userService.MakeUserActive(user);
            }
            else
                result = "";

            return result;
        }

    }
}
