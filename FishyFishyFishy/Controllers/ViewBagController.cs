using FishyFishyFishy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FishyFishyFishy.Controllers
{
    public class ViewBagController : Controller
    {
        public IActionResult Index()
        {


            List<Fish> fishList = new List<Fish>()
            {
                new Fish() {Name ="Shark", Speed = 20, Weight = 309 },
                new Fish() {Name ="Karasik", Speed = 5, Weight = 22},
                new Fish() {Name ="Plotva", Speed = 6, Weight = 2},
            };

            ViewBag.FishList = fishList;





            return View();
        }
    }
}
