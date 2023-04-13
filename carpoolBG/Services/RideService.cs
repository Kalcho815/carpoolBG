using carpoolBG.Data;
using carpoolBG.Models;
using Microsoft.EntityFrameworkCore;

namespace carpoolBG.Services
{
    public class RideService
    {
        private readonly CarpoolContext dbContext;

        public RideService(CarpoolContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public string CreateRideRequest(CarpoolUser user, double pickUpLat, double pickUpLong, double dropOffLat, double dropOffLong)
        {
            Location dropOffLocation = new Location() { Longitude = dropOffLong, Latitude = dropOffLat };
            Location pickUpLocation = new Location() { Longitude = pickUpLong, Latitude = pickUpLat };

            RideRequest rideRequest = new RideRequest();
            rideRequest.TimeMade = DateTime.Now;
            rideRequest.Accepted = false;
            rideRequest.PickUpLocation = pickUpLocation;
            rideRequest.DropOffLocation = dropOffLocation;
            rideRequest.RequestedBy = user;

            if (!user.Active)
            {
                user.Active = true;
                var userResult = dbContext.CarpoolUsers.Update(user); //making the user active
            }
                
            var rideRequestResult = dbContext.RideRequests.Add(rideRequest);

            var result = dbContext.SaveChanges();

            return result.ToString();
        }

        public ICollection<RideRequest> GetAvailableRideRequests()
        {
            var result = new List<RideRequest>();

            result = dbContext.RideRequests.Where(r => r.Accepted == false).ToList();

            return result;
        }

        public void AcceptRideRequest(string rideRequestId, string driverId)
        {
            var rideRequest = dbContext.RideRequests.Include(r=>r.DropOffLocation)
                .Include(r=>r.PickUpLocation)
                .Include(r=>r.RequestedBy)
                .FirstOrDefault(r=>r.Id == rideRequestId);

            rideRequest.Accepted = true;
            dbContext.RideRequests.Update(rideRequest);

            var ride = new Ride()
            {
                DriverId = driverId,
                DropOffLocation = rideRequest.DropOffLocation,
                PickUpLocation = rideRequest.PickUpLocation,
                Passenger = rideRequest.RequestedBy,
                Completed = false,
                TimeOfAcceptance = DateTime.Now,
                RideRequest = rideRequest,
            };

            dbContext.Rides.Add(ride);
            dbContext.SaveChanges();
        }

        public bool ConfirmPickUp(string rideId, string driverId)
        {
            var ride = dbContext.Rides
                .Include(r=>r.Driver)
                .FirstOrDefault(r => r.Id == rideId);


            //TODO: Null checks
            if(ride.DriverId != driverId)
            {
                return false;
            }

            ride.TimeOfPickUp = DateTime.Now;

            dbContext.Rides.Update(ride);
            dbContext.SaveChanges();
            return true;
        }

        public bool ConfirmDropOff(string rideId, string driverId)
        {
            var ride = dbContext.Rides
                .Include(r => r.Driver)
                .FirstOrDefault(r => r.Id == rideId);

            if (ride.DriverId != driverId)
            {
                return false;
            }

            ride.TimeOfDropOff = DateTime.Now;
            ride.Completed = true;
            //TODO: Implement cancelling ride

            dbContext.Rides.Update(ride);
            dbContext.SaveChanges();
            return true;
        }
    }
}
