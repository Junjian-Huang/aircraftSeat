using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aircraftSeatApi.Models
{
    public class Airline
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AirlineID { get; set; }      
        
        [Required]
        public string origin { get; set; }

        [Required]
        public string Destination { get; set; }

        // 1 airline has many seats
        [Required]
        public int SeatID { get; set; }


        
    }
}
