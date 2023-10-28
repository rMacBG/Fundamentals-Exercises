using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSomethingLoL.Interfaces
{
    public interface IWorker : IPerson
    {
        public IList<IPerson> Names { get; }
        public IList<IPerson> Emails { get; }
        public IList<IPerson> GetAll();
    }
}
