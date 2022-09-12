using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FishyFishyFishy.Controllers;
using FishyFishyFishy.Models;

namespace FishyFishyFishy.Controllers
{
    public class ModelController : Controller
    {
        public IActionResult Index()
        {

            List<Fish> fishList = new List<Fish>()
            {
                new Fish() {Name ="Shark", Speed = 20, Weight = 309 },
                new Fish() {Name ="Karasik", Speed = 5, Weight = 22},
                new Fish() {Name ="Plotva", Speed = 6, Weight = 2},
            };

            ViewData["Name"] = "Karp";
            ViewBag.Weight = 100;


            return View(fishList);
        }
    }
}
