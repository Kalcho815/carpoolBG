using carpoolBG.Data;
using carpoolBG.Models;
using carpoolBG.Services;
using Microsoft.AspNetCore.Mvc;

namespace carpoolBG.Controllers
{
    [Route("user/[controller]")]
    [ApiController]
    public class PreferencesController : ControllerBase
    {
        private readonly IHttpContextAccessor httpContext;
        private readonly CarpoolContext dbContext;
        private readonly string? username;
        private CarpoolUser user;
        PreferencesService preferencesService;

        public PreferencesController(IHttpContextAccessor httpContext, CarpoolContext dbContext, PreferencesService preferencesService)
        {
            this.httpContext = httpContext;
            this.dbContext = dbContext;
            this.preferencesService = preferencesService;
            this.username = httpContext.HttpContext.User.Identity.Name;

            if (username != null)
            {
                this.user = dbContext.Users
                    .Where(u => u.UserName == username)
                    .FirstOrDefault();
            }
        }

        [HttpPost(Name = "SetPreferences")]
        public string Post([FromQuery] string preferredSex, int maximumRange, string earliestDepartureTime, string earliestArrivalTime, string latestDepartureTime, string latestArrivalTime)
        {
            string result = "";

            if (user != null)
            {
                result = preferencesService.SetPreferences(user, preferredSex, maximumRange, earliestDepartureTime, earliestArrivalTime, latestDepartureTime, latestArrivalTime);
            }

            return result;
        }

    }
}
