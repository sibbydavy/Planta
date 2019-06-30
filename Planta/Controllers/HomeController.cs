using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Planta.Models;
//using Planta.Repository;

namespace Planta.Controllers
{
    public class HomeController : Controller
    {
        //IFarmRepository _farm;
        public HomeController() //IFarmRepository farm)
        {
          // _farm = farm;
        }
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult About()
        {
          //  FarmModel fm = new FarmModel() { Code =Guid.NewGuid(), CropDetails = null, Name = "test name" };
          ////  _farm.Create(fm);
          //  ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
