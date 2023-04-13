using carpoolBG.Data;
using carpoolBG.Models;

namespace carpoolBG.Services
{
    public class UserService
    {
        private readonly CarpoolContext dbContext;

        public UserService(CarpoolContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public string MakeUserActive(CarpoolUser user)
        {
            user.Active = true;
            var result = dbContext.CarpoolUsers.Update(user);
            dbContext.SaveChanges();
            
            return result.ToString();
        }
    }
}
