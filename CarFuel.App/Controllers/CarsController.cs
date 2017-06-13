using CarFuel.Models;
using CarFuel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarFuel.App.Controllers {
  public class CarsController : Controller {

    private CarService carService = new CarService();

    public ActionResult Index() {
      IEnumerable<Car> cars = carService.GetAll();
      return View(cars);
    }
  }
}