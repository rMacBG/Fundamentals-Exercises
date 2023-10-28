using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Vehicle
    {

        public Vehicle(string engine, string model, string brand)
        {
            Engine = engine;
            Model = model;
            Brand = brand;
        }
        public string Engine { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
    }
}
