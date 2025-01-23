using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        // Properties

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //Constructor for Car class
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

            //Increment static field numberOfCars with new car created
            CarLot.numberOfCars++;
        }

        public void MakeEngineNoise(string noise)
        {
            EngineNoise = noise;
            Console.WriteLine($"Engine noise: {EngineNoise}");
        }

        public void MakeHonkNoise(string noise)
        {
            HonkNoise = noise;
            Console.WriteLine($"Honk noise: {HonkNoise}");
        }
    }
}

