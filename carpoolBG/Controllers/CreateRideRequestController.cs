using carpoolBG.Data;
using carpoolBG.Models;
using carpoolBG.Services;
using Microsoft.AspNetCore.Mvc;

namespace carpoolBG.Controllers
{
    [Route("user/[controller]")]
    [ApiController]
    public class CreateRideRequestController : ControllerBase
    {
        private readonly IHttpContextAccessor httpContext;
        private readonly CarpoolContext dbContext;
        private readonly string? username;
        private CarpoolUser user;
        RideService rideService;

        public CreateRideRequestController(IHttpContextAccessor httpContext, CarpoolContext dbContext, RideService rideService)
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

        [HttpPost(Name = "CreateRideRequest")]
        public ActionResult<IEnumerable<RideRequest>> Post([FromQuery] double pickUpLat, double pickUpLong, double dropOffLat, double dropOffLong)
        {
            string result = "";

            if (user != null)
            {
                if(user.UserType != Models.Enums.UserType.Passenger)
                {
                    return Forbid("User must be of type driver!");
                }
                result = rideService.CreateRideRequest(user, pickUpLat, pickUpLong, dropOffLat, dropOffLong);
            }
            else
                return Unauthorized("User not logged in");

            return Ok(result);
        }

    }
}
