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

            for (int i = 0; i < _brokenParts.Count; i++)
            {
                Console.WriteLine($"{i+1} Запчасть - {_brokenParts[i].Name}");
            }
        }

        public bool GetNamePart() 
        {
            if (_brokenParts.Count == 0)
            {
                return true;
            }

            return false;
        }

        public string GetNamePart(int index) 
        {
            return _brokenParts[index].Name;
        }

        public void RemovePart(int index)
        {
            _brokenParts.RemoveAt(index);
        }

        private void AddBrokenParts()
        {
            DataBase dataBase = new DataBase();

            int maxValueParts = 4;

            _brokenParts = dataBase.GetParts(maxValueParts);
        }
    }
}