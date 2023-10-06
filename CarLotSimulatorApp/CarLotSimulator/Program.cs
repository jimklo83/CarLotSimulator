using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var carList = new CarLot();
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            Car car1 = new Car();
            car1.Year = 1990;
            car1.Make = "Pontiac";
            car1.Model = "Trans Am";
            car1.EngineNoise = "quiet";
            car1.HonkNoise = "normal";
            car1.IsDriveable = "driveable";
            
            car1.MakeEngineNoise();
            car1.MakeHonkNoise(car1.HonkNoise);
            Console.WriteLine();

            carList.OurCars.Add(car1);


            Car car2 = new Car() {Year = 2005, Make = "Cadillac", Model = "Escalade", EngineNoise = "loud", HonkNoise = "not working", IsDriveable = "not driveable" };

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise();
            Console.WriteLine();

            carList.OurCars.Add(car2);


            Car car3 = new Car(1998, "Jeep", "Grand Cherokee", "loud", "normal", "driveable");
            
            car3.MakeEngineNoise();
            car3.MakeHonkNoise(car3.HonkNoise);
            Console.WriteLine();

            carList.OurCars.Add(car3);


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine("Our cars' year, make, and model:");
            carList.GiveDetails();
        }
    }
}
