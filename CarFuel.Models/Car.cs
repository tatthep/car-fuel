using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFuel.Models {
  public class Car {

    public Guid Id { get; set; }

    public string Name { get; set; }
    public string PlateNo { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int EngineSizeCC { get; set; }

    public DateTime DateAdded { get; set; }
    public string OwnerId { get; set; }

  }
}
