using CarFuel.Models;
using CarFuel.Services;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CarFuel.App.Controllers {
  public class CarsController : Controller {

    private CarService carService = new CarService();

    public ActionResult Index() {
      IEnumerable<Car> cars = carService.GetAll();
      return View(cars);
    }

    public ActionResult Add() {
      return View();
    }

    [HttpPost]
    public ActionResult Add(Car item) {

      ModelState.Remove("DateAdded");

      if (ModelState.IsValid) {

        item.DateAdded = DateTime.Now;

        carService.Add(item);
        carService.SaveChanges();

        return RedirectToAction("Index");
      }

      return View(item);
    }

  }
}