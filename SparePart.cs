using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    internal class SparePart
    {
        public SparePart(string name) 
        {
            Name = name;

            State = GetState();
        }

        public string Name { get; private set; }

        public string State { get; private set; }

        private string GetState()
        {
            string [] states = { "Сломанная", "Целая" };

            int randomNumber = UserUtils.GetRandomNumber(states.Length);

            return states [randomNumber];
        }
    }
}