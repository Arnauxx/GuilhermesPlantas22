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

        public DbSet<GuilhermesPlantasAtt.Models.Department> Department { get; set; }
    }
}
