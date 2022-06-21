using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiteVendasMVC.Models;

namespace SiteVendasMVC.Controllers {
    public class DepartmentsController : Controller {
        public IActionResult Index() {
            List<Department> list = new List<Department>();
            list.Add(new Department { id = 1, Name = "Electronics"});
            list.Add(new Department { id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
