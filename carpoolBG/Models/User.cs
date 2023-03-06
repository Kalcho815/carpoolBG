using carpoolBG.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carpoolBG.Models
{
    public class User : IdentityUser
    {
        [Key]
        [Required]
        [Column("ID")]
        public string Id { get; set; }

        [Required]
        [Column("USERNAME")]
        public string Username { get; set; }

        [Required]
        [Column("DATE_OF_BIRTH")]
        public DateTime DateOfBirth { get;set; }

        [Required]
        [Column("SEX")]
        public Sex Sex { get; set; }

        [Required]
        [Column("EMAIL")]
        public string Email { get; set; }

        [Required]
        [Column("LOCATION")]
        public Location Location { get; set; }

        [Required]
        [Column("PREFERENCES")]
        public Preferences Preferences { get; set; }

        [Required]
        [Column("FIRST_NAME")]
        public string FirstName { get; set; }

        [Required]
        [Column("LAST_NAME")]
        public string LastName { get; set; }

        [Required]
        [Column("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }

        [Required]
        [Column("USER_TYPE")]
        public UserType UserType { get; set; }

        [Required]
        [Column("ACTIVE")]
        public bool Active { get; set; }

        public List<Ride> Rides { get; set; }

        public List<Rating> ReceivedRatings { get; set; }
        
    }
}
