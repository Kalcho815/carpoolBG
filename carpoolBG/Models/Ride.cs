using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace carpoolBG.Models
{
    [Table("RIDES")]
    public class Ride
    {
        public Ride()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        [Required]
        [Column("ID")]
        public string Id { get; set; }

        [Column("COMPLETED")]
        public string Completed { get; set; }

        [Column("TIME_OF_ACCEPTANCE")]
        public DateTime? TimeOfAcceptance { get; set; }

        [Column("DRIVER_ID")]
        [ForeignKey("DRIVER")]
        [Required]
        public string DriverId { get; set; }
        public User Driver { get; set; }


        [Column("PASSENGER_ID")]
        [ForeignKey("PASSENGER")]
        [Required]
        public string PassengerId { get; set; }
        public User Passenger { get; set; }

        [Column("PICK_UP_LOCATION_ID")]
        [ForeignKey("PICK_UP_LOCATION")]
        [Required]
        public string PickUpLocationId { get; set; }
        public Location PickUpLocation { get; set; }

        [Column("DROP_OFF_LOCATION_ID")]
        [ForeignKey("DROP_OFF_LOCATION")]
        [Required]
        public string DropOffLocationId { get; set; }
        public Location DropOffLocation { get; set; }

        [Column("TIME_OF_PICK_UP")]
        [Required]
        public DateTime TimeOfPickUp { get; set; }

        [Column("TIME_OF_DROP_OFF")]
        [Required]
        public DateTime TimeOfDropOff { get; set; }

        [Column("RIDE_REQUEST_ID")]
        [ForeignKey("RIDE_REQUEST")]
        [Required]
        public string RideRequestId { get; set; }
        public RideRequest RideRequest { get; set; } 
    }
}
