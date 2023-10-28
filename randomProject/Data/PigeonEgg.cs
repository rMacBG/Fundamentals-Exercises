using randomProject.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomProject.Data
{
    public class PigeonEgg : Egg, IEgg, IPigeonEgg
    {
        public PigeonEgg(string name, string type, string colour, string size, string pigeonName, string pigeonType) 
            : base(name, type, colour, size)
        {
            pigeonName = PigeonName;
            pigeonType = PigeonType;
        }

        public string PigeonName { get; set; }
        public string PigeonType { get; set; }
    }

   
}
