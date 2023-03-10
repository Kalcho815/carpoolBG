namespace carpoolBG.Models
{
    public class Driver : CarpoolUser
    {
        public Driver()
        {
            this.Documents = new List<byte[]>();
        }

        public List<byte[]> Documents { get; set; }

        public decimal Balancer { get; set; }
    }
}
