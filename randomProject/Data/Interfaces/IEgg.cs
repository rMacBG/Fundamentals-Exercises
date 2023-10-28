using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomProject.Data.Interfaces
{
    public interface IEgg
    {
        string Name { get; set; }
        string Type { get; set; }
        string Colour { get; set; }
        string Size { get; set; }
    }
}
