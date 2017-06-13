using CarFuel.Data;
using CarFuel.Models;
using System;
using System.Collections.Generic;

namespace CarFuel.Services {
  public class CarService {

    private CarRepository carRepo = new CarRepository();

    public IEnumerable<Car> GetAll() {
      return carRepo.Query((Car c) => true);
    }
  }
}