using GuilhermesPlantasAtt.Models;
using System.Collections.Generic;
using System.Linq;

namespace GuilhermesPlantasAtt.Services
{
    public class DepartmentService
    {
        private readonly GuilhermesPlantasAttContext _context;

        public DepartmentService(GuilhermesPlantasAttContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
