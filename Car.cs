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

        public Car(string name)
        {
            InstanceCounter++;

            Name = name + InstanceCounter;

            AddBrokenParts();
        }

        public static int InstanceCounter { get; private set; }

        public string Name { get; private set; }

        public void ShowBrokenParts()
        {
            Console.WriteLine($" Автомобиль {Name}\n" +
            $" Сломанные запчасти автомобиля : ");

            foreach (SparePart part in _brokenParts)
            {
                Console.WriteLine($" Запчасть - {part.Name}");
            }
        }

        private void AddBrokenParts()
        {
            DataBase dataBase = new DataBase();

            int maxValueParts = 4;

            _brokenParts = dataBase.GetParts(maxValueParts);
        }
    }
}