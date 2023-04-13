using carpoolBG.Data;
using carpoolBG.Models;
using carpoolBG.Services;
using Microsoft.AspNetCore.Mvc;

namespace carpoolBG.Controllers
{
    [Route("user/[controller]")]
    [ApiController]
    public class ConfirmDropOffController : ControllerBase
    {
        private readonly IHttpContextAccessor httpContext;
        private readonly CarpoolContext dbContext;
        private readonly string? username;
        private CarpoolUser user;
        RideService rideService;

        public ConfirmDropOffController(IHttpContextAccessor httpContext, CarpoolContext dbContext, RideService rideService)
        {
            this.httpContext = httpContext;
            this.dbContext = dbContext;
            this.rideService = rideService;
            this.username = httpContext.HttpContext.User.Identity.Name;

            if (username != null)
            {
                this.user = dbContext.Users
                    .Where(u => u.UserName == username)
                    .FirstOrDefault();
            }
        }

        [HttpPost(Name = "ConfirmDropOff")]
        public ActionResult Post(string rideRequestId)
        {
            if (user != null)
            {
                if (user.UserType != Models.Enums.UserType.Driver)
                {
                    return Forbid("Access forbidden");
                }

                var confirmed = rideService.ConfirmDropOff(rideRequestId, user.Id);
                if (confirmed)
                {
                    return Ok();
                }
                else
                    return Forbid("Driver must be assigned to a ride to confirm pick up.");
            }
            else
                return Unauthorized("User not logged in");

        }
    }
}
