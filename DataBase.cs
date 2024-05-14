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
            int minbValuePrice = 100;
            int maxValuePrice = 900;

            _parts.Add(new SparePart("Шаровая", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Крестовина", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Амортизатор", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Кардан", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Выхлопная труба", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Фара Левая", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Фара Правая", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Зеркало", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Бампер", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Крышка богажника", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Фаркоп", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Лючек бензобака", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Капот", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Поворотник Левый", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Поворотник Правый", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Дверь Левая передняя", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Дверь Правая передняя", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Дверь Левая Задняя", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
            _parts.Add(new SparePart("Дверь Правая Задняя", UserUtils.GetRandomNumber(minbValuePrice, maxValuePrice)));
        }

        public List<SparePart> GetParts()
        {
            List<SparePart> parts = new List<SparePart>(_parts);

            return parts;
        }

        public List<SparePart> GetParts(int numberParts)
        {
            List<SparePart> brokenParts = new List<SparePart>();

            List<SparePart> parts = new List<SparePart>(_parts);

            int index;

            for (int i = 0; i < numberParts; i++)
            {
                index = UserUtils.GetRandomNumber(parts.Count);

                brokenParts.Add(parts [index]);

                parts.Remove(parts [index]);
            }

            return brokenParts;
        }

        public void Show()
        {
            foreach (SparePart part in _parts)
            {
                Console.WriteLine($"Название {part.Name}");
            }
        }
    }
}
