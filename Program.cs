using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Car car = new Car("Машина");
            Car car1 = new Car("Машина");

            car.Show();
            car1.Show();
        }
    }
}
