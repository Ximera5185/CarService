using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    internal class Car
    {
        private List<SparePart> _parts = new List<SparePart>();

        public Car(string name) 
        {
            InstanceCounter++;

            Name = name + InstanceCounter;
        }

        public static int InstanceCounter { get; private set; }

        public string Name { get; private set; }


        public void Show() 
        {
            Console.WriteLine(Name);
        }
    }
}
