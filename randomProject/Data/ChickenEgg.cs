using randomProject.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomProject.Data
{
    public class ChickenEgg : Egg, IEgg, IChickenEgg
    {
        public ChickenEgg(string name, string type, string colour, string size, string chickenType, int yolksCount) 
            : base(name, type, colour, size)
        {
            chickenType = ChickenType;
            yolksCount = YolksCount;
        }
       
        public string ChickenType { get; set; }
        public int YolksCount { get; set; }
        public string ChickenName { get; set ; }
    }
}
