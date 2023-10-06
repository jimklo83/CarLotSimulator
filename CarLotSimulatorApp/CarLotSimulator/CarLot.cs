using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public List<Car> OurCars { get; set; }

        public CarLot() 
        {
            OurCars = new List<Car>();
        }

        public void GiveDetails() 
        {
            foreach (var car in OurCars) 
            {
                car.CarDetails();
            }
        }

    }
}
