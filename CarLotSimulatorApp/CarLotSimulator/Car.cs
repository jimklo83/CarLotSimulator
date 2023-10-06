using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() 
        {
            
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, string isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        public int Year {  get; set; }
        public string Make {  get; set; }
        public string Model {  get; set; }
        public string EngineNoise {  get; set; } 
        public string HonkNoise { get; set; }
        public string IsDriveable { get; set; }


        public void MakeEngineNoise(string engineNoise) 
        {
            EngineNoise = engineNoise;
            if (engineNoise == "loud")
            {
                Console.WriteLine($"The {Year} {Make} {Model} has a {EngineNoise} noise under the hood, have a mechanic inspect it.");
            }
            else 
            {
                Console.WriteLine($"The {Year} {Make} {Model} has a {EngineNoise} engine noise.");
            }
        }
        public void MakeEngineNoise() 
        {
            if (EngineNoise == "loud") 
            {
                Console.WriteLine($"The {Year} {Make} {Model} has a {EngineNoise} noise under the hood, have a mechanic inspect it.");
            }
            else
            {
                Console.WriteLine($"The {Year} {Make} {Model} has a {EngineNoise} engine noise.");
            }
        }

        public void MakeHonkNoise(string honkNoise) 
        {
            HonkNoise = honkNoise;
            if (honkNoise == "not working") 
            { 
                Console.WriteLine($"The horn on the {Year} {Make} {Model} is {HonkNoise}, have a mechanic replace it."); 
            }
            else 
            { 
                Console.WriteLine($"The horn on the {Year} {Make} {Model} is {HonkNoise}, it's working fine."); 
            }
        }

        public void MakeHonkNoise()
        {
            if ( HonkNoise == "not working")
            {
                Console.WriteLine($"The horn on the {Year} {Make} {Model} is {HonkNoise}, have a mechanic replace it.");
            }
            else
            {
                Console.WriteLine($"The horn on the {Year} {Make} {Model} is {HonkNoise}, it's working fine.");
            }
        }

        public void CarDetails()
        {
            Console.WriteLine($"A {Year} {Make} {Model}, {IsDriveable}.");
        }
    }
}
