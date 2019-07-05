using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(CarFactory.BuildCar(CarType.luxry));
            Console.Write(CarFactory.BuildCar(CarType.Micro));
            Console.Write(CarFactory.BuildCar(CarType.mini));
            Console.ReadKey();
        }
    }
}
