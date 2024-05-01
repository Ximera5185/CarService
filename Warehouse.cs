﻿using System;
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
            foreach (SparePart part in _parts)
            {
                Console.WriteLine($"{part.Name} {part.State}");

            }
        }
    }
}
