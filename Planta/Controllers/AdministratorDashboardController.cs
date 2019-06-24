using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Planta.Controllers
{
    public class AdministratorDashboardController : Controller
    {
        public IActionResult DashboardView()
        {
            return View();
        }
    }
}