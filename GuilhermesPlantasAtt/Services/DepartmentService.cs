using GuilhermesPlantasAtt.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GuilhermesPlantasAtt.Services
{
    public class DepartmentService
    {
        private readonly GuilhermesPlantasAttContext _context;

        public DepartmentService(GuilhermesPlantasAttContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
