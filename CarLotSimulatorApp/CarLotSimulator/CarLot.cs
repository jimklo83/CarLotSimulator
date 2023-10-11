using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> OurCars { get; set; } = new List<Car>(); //Define it all in one line


        public static int numberOfCars;
        
        public void GiveDetails() 
        {
            foreach (var car in OurCars) 
            {
                car.CarDetails();
            }
        }

        public void AddCar(Car car) 
        { 
            OurCars.Add(car);
            numberOfCars++;
            Console.WriteLine($"numberOfCars = {numberOfCars}");
            Console.WriteLine();
        } 
    }
}
