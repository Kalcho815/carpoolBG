using System.ComponentModel.DataAnnotations.Schema;

namespace carpoolBG.Models
{
    [Table("DRIVERS")]
    public class Driver : CarpoolUser
    {
        public Driver()
        {
            this.Documents = new List<byte[]>();
        }


        [Column("DOCUMENTS")]
        public List<byte[]> Documents { get; set; }

        [Column("BALANCE")]
        public decimal Balance { get; set; }
    }
}
