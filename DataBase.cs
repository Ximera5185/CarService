using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    internal class DataBase
    {
        private List<SparePart> _parts = new List<SparePart>();

        public DataBase() 
        {
            AddParts();
        }
        private void AddParts() 
        {
            _parts.Add(new SparePart("Шаровая"));
            _parts.Add(new SparePart("Шаровая"));
            _parts.Add(new SparePart("Шаровая"));
            _parts.Add(new SparePart("Шаровая"));
            _parts.Add(new SparePart("Шаровая"));
            _parts.Add(new SparePart("Шаровая"));
        }

        public void Show() 
        {
            foreach (SparePart part in _parts)
            {
                Console.WriteLine($"Название {part.Name} Состояние {part.State}");
            }
        }
    }
}
