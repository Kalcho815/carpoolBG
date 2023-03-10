using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carpoolBG.Models
{
    [Table("RATINGS")]
    public class Rating
    {
        public Rating()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        [Column("ID")]
        [Required]
        public string Id { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("SCORE")]
        [Required]
        public int Score { get; set; }

        [Required]
        [ForeignKey("POSTED_BY")]
        [Column("POSTED_BY_ID")]
        public string PostedById { get; set; }
        public CarpoolUser PostedBy { get; set; }

        [Required]
        [ForeignKey("RECEIVED_BY")]
        [Column("RECEIVED_BY_ID")]
        public string ReceivedById { get; set; }
        public CarpoolUser ReceivedBy { get; set; }

        [Column("TIME_POSTED")]
        [Required]
        public DateTime TimePosted { get; set; }
    }
}
