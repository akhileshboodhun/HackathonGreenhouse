using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hackathon_Greenhouse.Models;

namespace Hackathon_Greenhouse.Data
{
    public class Hackathon_GreenhouseContext : DbContext
    {
        public Hackathon_GreenhouseContext (DbContextOptions<Hackathon_GreenhouseContext> options)
            : base(options)
        {
        }

        public DbSet<Hackathon_Greenhouse.Models.SensorData> SensorData { get; set; }
    }
}
