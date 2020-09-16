using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aircraftSeatApi.Models
{
    public class Client
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientID { get; set; }

        
        public string Name { get; set; }
        
        public string Address { get; set; }
        
        public string Phone { get; set; }


    }
}
