using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();
            House house = new House();

            if (team.Work(house))
            {
                Console.WriteLine("Стройка завершена");
            }
            else
            {
                Console.WriteLine("Стройка не завершена");
            }
            Console.ReadLine();
        }
    }
}
