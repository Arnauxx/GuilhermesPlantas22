using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GuilhermesPlantasAtt.Models
{
    public class GuilhermesPlantasAttContext : DbContext
    {
        public GuilhermesPlantasAttContext (DbContextOptions<GuilhermesPlantasAttContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }


    }
}
