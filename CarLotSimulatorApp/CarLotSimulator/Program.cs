using Microsoft.VisualBasic;
using System;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating instance for CarLot
            CarLot carLot = new CarLot();

            //Instantiate 3 cars with different ways of setting properties
            //Car 1
            Car car1 = new Car

            {
                Year = 2000,
                Make = "Toyota",
                Model = "Camry",
                EngineNoise = "Vroom Vroom",
                HonkNoise = "Beep Beep",
                IsDriveable = true,
            };

            //Car 2
            Car car2 = new Car();
            car2.Year = 2021;
            car2.Make = "Honda";
            car2.Model = "Civic";
            car2.EngineNoise = "Zoom Zoom";
            car2.HonkNoise = "Honk Honk";
            car2.IsDriveable = false;

            //Car 3
            Car car3 = new Car
            {
                Year = 2022,
                Make = "Ford",
                Model = "Mustang",
                EngineNoise = "Rumble Rumble",
                HonkNoise = "BEEP BEEP",
                IsDriveable = true,
            };

            //Calling MakeEngineNoise and HonkNoise
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            //Add cars to list
            carLot.AddCar(car1);
            carLot.AddCar(car2);
            carLot.AddCar(car3);

            //Printing car details
            carLot.PrintCars();


            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
