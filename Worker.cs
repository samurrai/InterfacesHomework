using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomework
{
    public class Worker : IWorker
    {
        public int Work(IPart part)
        {
            if (!part.IsBuilt)
            {
                part.IsBuilt = true;
            }
            return 1;
        }
    }
}
