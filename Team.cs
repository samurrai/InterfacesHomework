using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomework
{
    public class Team
    {
        private IWorker[] workers;
        public Team()
        {
            workers = new IWorker[6];
            for (int i = 0; i < 5; i++)
            {
                workers[i] = new Worker();
            }
            workers[5] = new TeamLeader();
        }
        public bool Work(House house)
        {
            int i = 0;
            int j = 0;
            while (true)
            {
                if (i == workers.Length)
                {
                    i = 0;
                }
                if (j == house.Parts.Length)
                {
                    break;
                }
                if (workers[i] is TeamLeader)
                {
                    Console.WriteLine(workers[i].Work(house.Parts[j]));
                }
                workers[i].Work(house.Parts[j]);
                i++;
                j++;
            }
            return true;
        }
    }
}
