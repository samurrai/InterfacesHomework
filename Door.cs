using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomework
{
    public class Door : IPart
    {
        public bool IsBuilt { get; set; }
        public int Index { get; set; }
    }
}
