using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
   
    public class CarLot
    {

        //Static field tracking number of cars
        public static int numberOfCars = 0;

        //Property to hold a list of cars
        public List<Car> Cars { get; set; }

        //Constructor to initialize the list
        public CarLot()
        {
            Cars = new List<Car>();
        }

        //Method to add car to list
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        //Method to print details of each car
        public void PrintCars()
        {
            foreach (var car in Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }

        }
    }
}
