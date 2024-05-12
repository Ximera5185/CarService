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
            _parts.Add(new SparePart("Крестовина"));
            _parts.Add(new SparePart("Амортизатор"));
            _parts.Add(new SparePart("Кардан"));
            _parts.Add(new SparePart("Выхлопная труба"));
            _parts.Add(new SparePart("Фара Левая"));
            _parts.Add(new SparePart("Фара Правая"));
            _parts.Add(new SparePart("Зеркало"));
            _parts.Add(new SparePart("Бампер"));
            _parts.Add(new SparePart("Крышка богажника"));
            _parts.Add(new SparePart("Фаркоп"));
            _parts.Add(new SparePart("Лючек бензобака"));
            _parts.Add(new SparePart("Капот"));
            _parts.Add(new SparePart("Поворотник Левый"));
            _parts.Add(new SparePart("Поворотник Правый"));
            _parts.Add(new SparePart("Дверь Левая передняя"));
            _parts.Add(new SparePart("Дверь Правая передняя"));
            _parts.Add(new SparePart("Дверь Левая Задняя"));
            _parts.Add(new SparePart("Дверь Правая Задняя"));
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

                brokenParts.Add(parts[index]);

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
