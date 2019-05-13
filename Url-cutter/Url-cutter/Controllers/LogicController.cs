using Url_cutter.Models.DataModels;
using Microsoft.AspNetCore.Mvc;
using Url_cutter.Services;
using System.Threading.Tasks;
using System;
using Url_cutter.Models.ViewModels;

namespace Url_cutter.Controllers
{
    public class LogicController : Controller
    {
        private const int sizeOfURL = 5;

        private readonly ICutterService service;

        public LogicController(ICutterService service)
        {
                this.service = service;
        }

        public async Task<IActionResult> Create(IndexViewModel model)
        {
            StoredUrl url = new StoredUrl
            {
                BaseUrl = model.ToCutUrl.BaseUrl,
                ShortUrl = URLGenerator.GetUniqueURL(sizeOfURL),
                CreationDate = DateTime.Now,
                Transition = 0
            };

            await service.Save(url);
            
            return RedirectToAction("Index","Home");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var url = await service.GetById(id);
            await service.Delete(url);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Transition(int id)
        {
           var url = await service.GetById(id);
           await service.IncrementTransition(url);

           if(url.BaseUrl.StartsWith("http://") || url.BaseUrl.StartsWith("https://"))
               return Redirect(url.BaseUrl);

            return Redirect("http://" + url.BaseUrl);
        }
    }
}