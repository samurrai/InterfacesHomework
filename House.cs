using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomework
{
    public class House
    {
        public Basement Basement { get; set; }
        public Walls[] Walls { get; set; }
        public Door Door { get; set; }
        public Window[] Windows { get; set; }
        public Roof Roof { get; set; }
        public IPart[] Parts { get; set; }

        public House()
        {
            Parts = new IPart[11];

            Basement = new Basement();
            Basement.Index = 0;
            Basement.IsBuilt = false;

            Parts[0] = Basement;
            
            Walls = new Walls[4];
            for (int i = 0; i < Walls.Length; i++)
            {
                Walls[i] = new Walls();
                Walls[i].Index = Basement.Index + i + 1;
                Walls[i].IsBuilt = false;
                Parts[i + 1] = Walls[i];
            }

            Door = new Door();
            Door.Index = Walls[3].Index + 1;
            Door.IsBuilt = false;

            Parts[5] = Door;

            Windows = new Window[4];
            for(int i = 0; i < Windows.Length; i++)
            {
                Windows[i] = new Window();
                Windows[i].Index = Door.Index + i + 1;
                Windows[i].IsBuilt = false;
                Parts[i + 6] = Windows[i];
            }
            Roof = new Roof();
            Roof.Index = Windows[3].Index + 1;
            Roof.IsBuilt = false;
            
            Parts[10] = Roof;
        }
    }
}
