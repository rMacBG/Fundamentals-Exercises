using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomProject.Data.Interfaces
{
    public interface IChickenEgg
    {
        public string ChickenName { get; set; }
        string ChickenType { get; set; }
        int YolksCount { get; set; }

    }
}
