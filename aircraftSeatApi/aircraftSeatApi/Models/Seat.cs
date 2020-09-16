using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aircraftSeatApi.Models
{
    public class Seat
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int SeatID { get; set; }

        
        [Required]
        public int ClientID { get; set; }


        [Required]
        public int AirlineID { get; set; }


        
    }
}
