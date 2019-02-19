using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomework
{
    public class TeamLeader : IWorker
    {
        public int Work(IPart part)
        {
            return part.Index;
        }
    }
}
