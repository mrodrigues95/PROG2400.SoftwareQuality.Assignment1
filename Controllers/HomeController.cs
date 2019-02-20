using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MRAssignment1.Models;

namespace MRAssignment1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SimpleConversionViewModel model, string command)
        {
            if (command == "Convert to Binary") {                
                model.Result = MRSimpleConversionBL.SimpleConversions.ConvertDecimalToBinary(model.NumberToBeConverted);
                TempData["result"] = model.Result;
            }
            if (command == "Convert to Decimal")
            {
                model.Result = MRSimpleConversionBL.SimpleConversions.ConvertDecimalToBinary(model.NumberToBeConverted);
                TempData["result"] = model.Result;
            }

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
