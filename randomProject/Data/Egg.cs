using randomProject.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomProject.Data
{
    public class Egg : IEgg
    {
        public Egg(string name, string type, string colour, string size)
        {
            name = Name;
            type = Type;
            colour = Colour;
            size = Size;

        }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Colour { get; set; }
        public string Size { get; set; }    
    }
}
