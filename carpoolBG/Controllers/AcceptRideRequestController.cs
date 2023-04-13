using carpoolBG.Data;
using carpoolBG.Models;
using carpoolBG.Services;
using Microsoft.AspNetCore.Mvc;

namespace carpoolBG.Controllers
{
    [Route("user/[controller]")]
    [ApiController]
    public class AcceptRideRequestController : ControllerBase
    {
        private readonly IHttpContextAccessor httpContext;
        private readonly CarpoolContext dbContext;
        private readonly string? username;
        private CarpoolUser user;
        RideService rideService;

        public AcceptRideRequestController(IHttpContextAccessor httpContext, CarpoolContext dbContext, RideService rideService)
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
        //TODO: Drivers cannot make ride requests
        [HttpPost(Name = "AcceptRideRequest")]
        public ActionResult<IEnumerable<RideRequest>> Post(string rideRequestId)
        {
            string result = "";

            if (user != null)
            {
                if(user.UserType != Models.Enums.UserType.Driver)
                {
                    return Forbid("Access forbidden");
                }
                rideService.AcceptRideRequest(rideRequestId, user.Id);
            }
            else
                return Unauthorized("User not logged in");

            return Ok(result);
        }

    }
}
