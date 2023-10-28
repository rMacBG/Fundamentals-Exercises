using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Car : Vehicle
    {
        public Car(string engine, string model, string brand, double fuelConsumption, string tyres, string doors, 
            string steeringWheel, string backLights, string frontLights, string signalLights, string brakes, string radio)
        : base(engine, model, brand)
        {
           FuelConsumption = fuelConsumption;
            Tyres = tyres;
            Doors = doors;
            SteeringWheel = steeringWheel;
            BackLights = backLights;
            FrontLights = frontLights;
            SignalLights = signalLights;
            Brakes = brakes;
            Radio = radio;
        }

        public double FuelConsumption { get; set; }
        public string Tyres { get; set; }
        public string Doors { get; set; }
        public string SteeringWheel { get; set; }
        public string BackLights { get; set; }
        public string FrontLights { get; set; }
        public string SignalLights { get; set; }
        public string Brakes { get; set; }
        public string Radio { get; set; }
        public override string ToString()
        {
            return $"{Engine}, {Model}, {Brand}, {FuelConsumption}, {Tyres}, {Doors}, {SteeringWheel}, {BackLights}, {FrontLights}, {SignalLights}, {Brakes}, {Radio}";
        }
    }
}
