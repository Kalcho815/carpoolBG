using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carpoolBG.Models
{
    [Table("RIDE_REQUESTS")]
    public class RideRequest
    {
        public RideRequest()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        [Required]
        [Column("ID")]
        public string Id { get; set; }

        [ForeignKey("DROP_OFF_LOCATION")]
        [Column("DROP_OFF_LOCATION")]
        [Required]
        public string DropOffLocationId { get; set; }
        public Location DropOffLocation { get; set; }

        [ForeignKey("PICK_UP_LOCATION")]
        [Column("PICK_UP_LOCATION_ID")]
        [Required]
        public string PickUpLocationId { get; set; }
        public Location PickUpLocation { get; set; }

        public User RequestedBy { get; set; }

        [Column("ACCEPTED")]
        [Required]
        public bool Accepted { get; set; }

        [Column("TIME_MADE")]
        [Required]
        public DateTime TimeMade { get; set; }

        public Ride? Ride { get; set; }
    }
}
