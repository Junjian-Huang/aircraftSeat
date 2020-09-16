using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aircraftSeatApi.Models
{
    public class AppDatabase : DbContext
    {
        public AppDatabase(DbContextOptions<AppDatabase> options) : base(options)
        {

        }

        public DbSet<Airline> Airline { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Seat> Seat { get; set; }
        
    }
}
