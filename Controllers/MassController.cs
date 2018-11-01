using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TempConverter.Models;

namespace TempConverter.Controllers
{
    public class MassController : Controller
    {

      public IActionResult Index()
        {
            return View();

}
//Ounces to Pounds

         public IActionResult Ounces(decimal cOunces = 100) //converts Ounces to Pounds
        {
            cOunces = cOunces * 0.0625m;
            //ViewData["Message"] = "Hello " + name;
            ViewData["Ounces"] = cOunces;

            return View();
        }



    public IActionResult Pounds(decimal fPounds = 100)  //converts Pounds to Ounces  
        
        {
            fPounds = fPounds*16m;
            //ViewData["Message"] = "Hello " + name;
            ViewData["Pounds"] = fPounds;

            return View();
        }

    }
}
