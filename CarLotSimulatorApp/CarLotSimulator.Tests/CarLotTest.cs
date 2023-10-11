using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator.Tests
{
    public class CarLotTest
    {
        [Fact]
        public void CarLot_AddCar_ShouldUpdateNumberOfCars() 
        {
            var carLot = new CarLot ();

            var car = new Car ();

            carLot.AddCar (car);

            var carNumber = CarLot.numberOfCars;

            Assert.Equal(1, carNumber);
        }
    }
}
