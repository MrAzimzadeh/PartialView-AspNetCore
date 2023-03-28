using Microsoft.AspNetCore.Mvc;
using PartialView.Models;
using System.Diagnostics;
using NuGet.Versioning;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var images = new List<string>
            {
                "https://cdn.pixabay.com/photo/2015/06/19/21/24/avenue-815297_960_720.jpg" ,
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTKRzHHirDMQU_v0RHsILVKVt2O2RzpYR_EA_wiH5XaZQiOO_SBqb_8clGzD2cNXMTFoB0&usqp=CAU" ,
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3Gg_QYj5RAGQ8M0e3JDMOM1RkgW7077TrT-KeYx0Qms5d0j-osyzAaTetbGgc6Yq0YjM&usqp=CAU"
            };
            return View(images);
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