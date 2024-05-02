using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    internal class CreatorCar
    {
        private DataBase _dataBase = new DataBase();

        private int _numberWorkingParts = 2;
        private int _numberBrokenParts = 2;

        public Car CreateCar()
        {
            return new Car("Машина", _dataBase.GetParts(_numberWorkingParts), _dataBase.GetParts(_numberBrokenParts));
        }
    }
}
