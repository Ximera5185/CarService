using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    internal class Car
    {
        private List<SparePart> _workingParts = new List<SparePart>();
        private List<SparePart> _brokenParts = new List<SparePart>();

        public Car(string name, List<SparePart> workingParts, List<SparePart> brokenParts) 
        {
            InstanceCounter++;

            Name = name + InstanceCounter;

            _workingParts = workingParts;

            _brokenParts = brokenParts;
        }

        public static int InstanceCounter { get; private set; }

        public string Name { get; private set; }

        public void Show() 
        {
            Console.WriteLine(Name);
        }
    }
}
