using carpoolBG.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace carpoolBG.Models
{
    public class CarpoolUser : IdentityUser
    {
        public CarpoolUser()
        {
            this.RidesDriver = new List<Ride>();
            this.RidesPassenger = new List<Ride>();
            this.ReceivedRatings = new List<Rating>();
            this.PostedRatings = new List<Rating>();
            this.SavedLocations = new List<Location>();
            this.Location = new Location();
            this.Preferences = new Preferences();
            this.Documents = Array.Empty<byte>();    
        }


        [Required]
        [Column("DATE_OF_BIRTH")]
        public DateTime DateOfBirth { get;set; }

        [Required]
        [Column("SEX")]
        public Sex Sex { get; set; }

        [Required]
        [Column("LOCATION")]
        public Location Location { get; set; }

        [Required]
        [Column("PREFERENCES")]
        public Preferences Preferences { get; set; }

        [Required]
        [Column("FIRST_NAME")]
        public string? FirstName { get; set; }

        [Required]
        [Column("LAST_NAME")]
        public string? LastName { get; set; }

        [Required]
        [Column("USER_TYPE")]
        public UserType UserType { get; set; }

        [Required]
        [Column("ACTIVE")]
        public bool Active { get; set; }

        [Column("SAVED_LOCATIONS")]
        public List<Location> SavedLocations { get; set; }

        [Column("DOCUMENTS")]
        [AllowNull]
        public byte[]? Documents { get; set; }

        [Column("BALANCE")]
        public decimal Balance { get; set; }

        public List<Ride> RidesDriver { get; set; }
        public List<Ride> RidesPassenger { get; set; }

        public List<Rating> PostedRatings { get; set; }
        public List<Rating> ReceivedRatings { get; set; }

    }
}
