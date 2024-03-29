﻿using System.ComponentModel.DataAnnotations;
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

        [Required]
        [Column("LATITUDE")]
        public double Latitude { get; set; }

        [Required]
        [Column("LONGITUDE")]
        public double Longitude { get; set; }

        public Ride RidePickUp { get; set; }
        public Ride RideDropOff { get; set; }

        public CarpoolUser Passenger{ get; set; }
    }
}
