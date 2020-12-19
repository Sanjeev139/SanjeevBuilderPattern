using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{

    class Program
    {
        static void Main(string[] args)
        {


            var carNano = new CarCreator(new CarBuilder());
            carNano.BuildCar();
            carNano.GetCarDetails();
            Console.ReadLine();
        }
    }
}
