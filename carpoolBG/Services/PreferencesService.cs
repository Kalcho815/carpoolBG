using carpoolBG.Data;
using carpoolBG.Models;
using carpoolBG.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace carpoolBG.Services
{
    public class PreferencesService
    {
        private readonly CarpoolContext dbContext;

        public PreferencesService(CarpoolContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public string SetPreferences(CarpoolUser user, string preferredSex, int maximumRange, string earliestDepartureTime, string earliestArrivalTime, string latestDepartureTime, string latestArrivalTime)
        {
            string result = "";
            Sex preferredSexToSet = Sex.NotStated;
            if (preferredSex.ToLower() == "male") 
            {
                preferredSexToSet = Sex.Male;
            }
            else if(preferredSex.ToLower() == "female")
            {
                preferredSexToSet = Sex.Female;
            }

            TimeSpan earliestDepartureSpan = new TimeSpan();
            TimeSpan earliestArrivalSpan = new TimeSpan();
            TimeSpan latestDepartureSpan = new TimeSpan();
            TimeSpan latestArrivalSpan = new TimeSpan();

            if (earliestDepartureTime != null)
            {
                earliestDepartureSpan = TimeSpan.Parse(earliestDepartureTime);
            }

            if(earliestArrivalTime != null)
            {
                earliestArrivalSpan = TimeSpan.Parse(earliestArrivalTime);
            }

            if(latestDepartureTime != null)
            {
                latestDepartureSpan = TimeSpan.Parse(latestDepartureTime);
            }

            if (latestArrivalTime != null)
            {
                latestArrivalSpan = TimeSpan.Parse(latestArrivalTime);
            }

            Preferences preferencesToAdd = new Preferences()
            {
                LatestArrivalTime = latestArrivalSpan,
                LatestDepartureTime = latestDepartureSpan,
                EarliestArrivalTime = earliestArrivalSpan,
                EarliestDepartureTime = earliestArrivalSpan,
                MaximumRange = maximumRange,
                PreferredSex = preferredSexToSet,
                User = user,
            };

            var currentPreferences = dbContext.Preferences.Where(p=>p.UserId == user.Id).FirstOrDefault();

            if (currentPreferences != null)
            {
                dbContext.Preferences.Remove(currentPreferences);
            }

            dbContext.Preferences.Add(preferencesToAdd);
            dbContext.SaveChanges();
            result = "Updated";

            return result;
        }
    }
}
