using AddMulTwoNum.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AddMulTwoNum.Controllers
{
   public class HomeController : Controller
   {
      //private readonly ILogger<HomeController> _logger;

      //public HomeController(ILogger<HomeController> logger)
      //{
      //   _logger = logger;
      //}
      [HttpGet]
      public IActionResult Index()
      {
         ViewBag.Sum = 0;
         ViewBag.Product = 0;
         return View();
      }
      [HttpPost]
      public IActionResult Index(AddMulTwoNumModel val)
      {
         if (ModelState.IsValid)
         {
            ViewBag.Sum = val.AddTwoNum();
            ViewBag.Product = val.MulTwoNum();
         }
         else
         {
            ViewBag.Sum = 0;
            ViewBag.Product = 0;
         }
        
         return View(val);
      }
         //public IActionResult Privacy()
         //{
         //   return View();
         //}

         //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
         //public IActionResult Error()
         //{
         //   return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
         //}
      }
   }