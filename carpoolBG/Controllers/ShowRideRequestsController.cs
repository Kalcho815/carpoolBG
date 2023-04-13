using carpoolBG.Data;
using carpoolBG.Models;
using carpoolBG.Services;
using Microsoft.AspNetCore.Mvc;

namespace carpoolBG.Controllers
{
    [Route("user/[controller]")]
    [ApiController]
    public class ShowRideRequestsController : ControllerBase
    {
        private readonly CarpoolContext dbContext;
        private readonly IHttpContextAccessor httpContext;
        private readonly RideService rideService;
        private readonly CarpoolUser? user;
        private string? username;

        public ShowRideRequestsController(CarpoolContext dbContext, IHttpContextAccessor httpContext, RideService rideService)
        {
            this.dbContext = dbContext;
            this.httpContext = httpContext;
            this.rideService = rideService;
            this.username = httpContext.HttpContext.User.Identity.Name;

            if (username != null)
            {
                this.user = dbContext.Users
                    .Where(u => u.UserName == username)
                    .FirstOrDefault();
            }
        }

        [HttpGet(Name = "ShowRideRequests")]
        public IActionResult Get()
        {
            if(this.user.UserType == Models.Enums.UserType.Passenger)
            {
                return StatusCode(403, "User must be of type driver");
            }

            var content = rideService.GetAvailableRideRequests();

            return Ok(content);
        }
    }
}
