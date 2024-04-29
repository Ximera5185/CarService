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

        private void AddParts() 
        {
            _parts.Add(new SparePart("Шаровая"));
        }
    }
}
