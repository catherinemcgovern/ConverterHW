using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TempConverter.Models;

namespace TempConverter.Controllers
{
    public class LengthController : Controller
    {

      public IActionResult Index()
        {
            return View();

}


         public IActionResult Feet(decimal cFeet = 100) //converts meters to feet
        {
            cFeet = cFeet * 3.28084m;
            //ViewData["Message"] = "Hello " + name;
            ViewData["Feet"] = cFeet;

            return View();
        }



    public IActionResult Meter(decimal fMeter = 100)
        {
            fMeter = fMeter*0.3048m;
            //ViewData["Message"] = "Hello " + name;
            ViewData["Meter"] = fMeter;

            return View();
        }

    }
}
