using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            CatalogueVehicle catalogueVehicle = new CatalogueVehicle();
            string input;
            while ((input=Console.ReadLine()) !="end")
            {
                string[] inputInfo = input.Split("/");
                string type = inputInfo[0];
                string brand = inputInfo[1];
                string model = inputInfo[2];
                int horsePower = int.Parse(inputInfo[3]);
                if (type== "Car")
                {
                    Car car = new Car (brand, model, horsePower);
                    catalogueVehicle.cars.Add(car);
                }
                else if (type =="Truck")
                {
                    Truck truck = new Truck(brand, model, horsePower);
                    catalogueVehicle.trucks.Add(truck);
                    
                }
            }
            Console.WriteLine("Cars: ");
            foreach (Car car in catalogueVehicle.cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine();
            Console.WriteLine("Trucks: ");
            foreach (Truck truck in catalogueVehicle.trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}
