using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carpoolBG.Models
{
    [Table("LOCATIONS")]
    public class Location
    {
        public Location() 
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        [Key]
        [Column("ID")]
        public string Id { get; set; }

        [Column("COUNTRY")]
        [Required]
        public string Country { get; set; }

        [Column("CITY")]
        [Required]
        public string City { get; set; }

        [Column("POST_CODE")]
        [Required]
        public string PostCode { get; set; }

        [Column("STREET")]
        [Required]
        public string Street { get; set; }

        [Column("NUMBER")]
        [Required]
        public string Number { get; set; }

        [Column("NAME")]
        [Required]
        public string Name { get; set; }

        public Ride Ride { get; set; }

        public User User
    }
}
