using CarFuel.Models;
using CarFuel.Services;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace CarFuel.App.Controllers
{

    [Authorize]
    public class CarsController : Controller
    {

        private CarService carService = new CarService();

        public ActionResult Index()
        {
            IEnumerable<Car> cars = carService.GetAll();

            return View(cars);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Car item)
        {

            ModelState.Remove("DateAdded");

            if (ModelState.IsValid)
            {

                item.OwnerId = User.Identity.GetUserId();
                item.DateAdded = DateTime.Now;

                carService.Add(item);
                carService.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(item);
        }

    }
}