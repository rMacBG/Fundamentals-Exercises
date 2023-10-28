using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace VehicleCatalogue
{
    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }
    public class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();

        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
 
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }
                string[] tokens = line.Split('/');

                string vehicleType = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                string index = tokens[3];

                if (vehicleType == "Car")
                {
                        Car car = new Car();
                        car.Brand = brand;
                        car.Model = model;
                        car.HorsePower = index;
                        catalog.Cars.Add(car);
                    
                }

                else if (vehicleType == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = index;
                    catalog.Trucks.Add(truck);
                }
  
            }


           
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (Car car in catalog.Cars.OrderBy(car => car.Brand))
                {

                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Truck truck in catalog.Trucks.OrderBy(truck => truck.Brand))
                {

                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }

    }
}

            
 