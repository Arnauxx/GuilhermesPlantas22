using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuilhermesPlantasAtt.Models;

namespace GuilhermesPlantasAtt.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Natural" });
            list.Add(new Department { Id = 2, Name = "Artificial" });

            return View(list);
        }
    }
}
