using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TempConverter.Models;

namespace TempConverter.Controllers
{
    public class TempController : Controller
    {

      public IActionResult Index()
        {
            return View();

}


         public IActionResult Temp(decimal cTemp = 100)
        {
            cTemp = cTemp * (1.8m) + 32;
            //ViewData["Message"] = "Hello " + name;
            ViewData["Temp"] = cTemp;

            return View();
        }



    public IActionResult FahrenTemp(decimal fTemp = 100)
        {
            fTemp = (fTemp-32) * (5m/9m);  //([°F] - 32) × 5/9
            //ViewData["Message"] = "Hello " + name;
            ViewData["FahrenTemp"] = fTemp;

            return View();
        }

    }
}
