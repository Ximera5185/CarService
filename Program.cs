using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("База данных");
            DataBase dataBase = new DataBase();

            dataBase.Show();


            Console.WriteLine("Склад");
            Warehouse warehouse = new Warehouse();

            warehouse.Show();
            
        }
    }
}
