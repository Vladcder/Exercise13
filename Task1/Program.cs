using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Улица Пушкина 1", 10,10,10);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Улица Пушкина 1", 10, 10, 30, 3);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
