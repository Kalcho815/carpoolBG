using carpoolBG.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carpoolBG.Models
{
    [Table("PREFERENCES")]
    public class Preferences
    {
        public Preferences()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        [Column("ID")]
        [Required]
        public string Id { get; set; }

        [Column("PREFERRED_SEX")]
        public Sex PreferredSex { get; set; }

        [Column("MAXIMUM_RANGE")]
        public int MaximumRange { get; set; }

        [Column("EARLIEST_DEPARTURE_TIME")]
        public TimeSpan EarliestDepartureTime { get; set; }

        [Column("EARLIEST_ARRIVAL_TIME")]
        public TimeSpan EarliestArrivalTime { get; set; }

        [Column("LATEST_DEPARTURE_TIME")]
        public TimeSpan LatestDepartureTime { get; set; }

        [Column("LATEST_ARRIVAL_TIME")]
        public TimeSpan LatestArrivalTime { get; set; }

        public CarpoolUser User { get; set; }

        [Required]
        [ForeignKey("USER")]
        [Column("USER_ID")]
        public string UserId { get; set; }
    }
}
