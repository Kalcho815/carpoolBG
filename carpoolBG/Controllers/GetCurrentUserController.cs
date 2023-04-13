using carpoolBG.Data;
using carpoolBG.Models;
using carpoolBG.Services;
using Microsoft.AspNetCore.Mvc;

namespace carpoolBG.Controllers
{
    [Route("user/[controller]")]
    [ApiController]
    public class GetCurrentUserController : ControllerBase
    {
        private readonly CarpoolContext dbContext;
        private readonly IHttpContextAccessor httpContext;
        private readonly UserService userService;
        private readonly CarpoolUser? user;
        private string? username;

        public GetCurrentUserController(CarpoolContext dbContext, IHttpContextAccessor httpContext)
        {
            this.dbContext = dbContext;
            this.httpContext = httpContext;
            this.username = httpContext.HttpContext.User.Identity.Name;

            if (username != null)
            {
                this.user = dbContext.Users
                    .Where(u => u.UserName == username)
                    .FirstOrDefault();
            }
        }

        [HttpGet(Name = "GetCurrentUser")]
        public IActionResult Get()
        {
            if(user == null)
            {
                return StatusCode(401, "User not logged in");
            }

            return Ok(user);
        }
    }
}
