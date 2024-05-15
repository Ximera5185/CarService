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
        
        public Car Create()
        {
            return new Car("Машина");
        }
    }
}
