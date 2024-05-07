using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    internal class Car
    {
        private List<SparePart> _brokenParts = new List<SparePart>();

        public Car(string name, List<SparePart> brokenParts) 
        {
            InstanceCounter++;

            Name = name + InstanceCounter;

            _brokenParts = brokenParts;
        }

        public static int InstanceCounter { get; private set; }

        public string Name { get; private set; }

        public void Show() 
        {
            Console.WriteLine(Name);
        }

        public void ShowBrokenParts() 
        {
            Console.WriteLine("brokenParts");

            foreach (SparePart part in _brokenParts)
            {
                Console.WriteLine($" part - {part.Name}");
            }
        }
    }
}
