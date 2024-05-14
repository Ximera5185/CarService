using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    internal class Warehouse
    {
        private DataBase _data = new DataBase();

        private List<SparePart> _parts = new List<SparePart>();

        public Warehouse() 
        {
            _parts = _data.GetParts();
        }

        public void Show() 
        {
            Console.WriteLine("Запчасти на складе ");

            foreach (SparePart part in _parts)
            {
                Console.WriteLine($"{part.Name}");
            }

            Console.WriteLine();
        }

        public bool GetParts(string name) 
        {
            foreach (SparePart part in _parts)
            {
                if (name == part.Name)
                {
                    _parts.Remove(part);

                    return true;
                }
            }

            return false;
        }
        
        public bool TryGetParts(string name)
        {
            foreach (SparePart part in _parts)
            {
                if (name == part.Name)
                {
                    _parts.Remove(part);

                    return true;
                }
            }

            return false;
        }
    }
}
