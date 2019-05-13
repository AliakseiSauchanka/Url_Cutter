using System;
using System.Collections.Generic;
using System.Diagnostics;
using Url_cutter.Models.ViewModels;
using Url_cutter.Services;
using Microsoft.AspNetCore.Mvc;
using Url_cutter.Models;
using Url_cutter.Data;

namespace Url_cutter.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    public class HomeController : Controller
    {
        private readonly ICutterService service; 

        public HomeController(ICutterService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.StoredUrls = service.GetAll().ToList();

            return View(model);
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
