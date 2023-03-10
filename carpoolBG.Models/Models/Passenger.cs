using System.ComponentModel.DataAnnotations.Schema;

namespace carpoolBG.Models
{
    [Table("PASSENGERS")]
    public class Passenger : CarpoolUser
    {
        public Passenger()
        {
            SavedLocations = new List<Location>();
        }

        [Column("SAVED_LOCATIONS")]
        public List<Location> SavedLocations { get; set; }
    }
}
