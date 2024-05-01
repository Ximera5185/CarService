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
            _parts.Add(new SparePart("Шаровая","Новая"));
            _parts.Add(new SparePart("Крестовина", "Новая"));
            _parts.Add(new SparePart("Амортизатор", "Новая"));
            _parts.Add(new SparePart("Кардан", "Новая"));
            _parts.Add(new SparePart("Выхлопная труба", "Новая"));
            _parts.Add(new SparePart("Фара Левая", "Новая"));
            _parts.Add(new SparePart("Фара Правая", "Новая"));
            _parts.Add(new SparePart("Зеркало", "Новая"));
            _parts.Add(new SparePart("Бампер", "Новая"));
            _parts.Add(new SparePart("Крышка богажника", "Новая"));
            _parts.Add(new SparePart("Фаркоп", "Новая"));
            _parts.Add(new SparePart("Лючек бензобака", "Новая"));
            _parts.Add(new SparePart("Капот", "Новая"));
            _parts.Add(new SparePart("Поворотник Левый", "Новая"));
            _parts.Add(new SparePart("Поворотник Правый", "Новая"));
            _parts.Add(new SparePart("Дверь Левая передняя", "Новая"));
            _parts.Add(new SparePart("Дверь Правая передняя", "Новая"));
            _parts.Add(new SparePart("Дверь Левая Задняя", "Новая"));
            _parts.Add(new SparePart("Дверь Правая Задняя", "Новая"));
        }

        public List<SparePart> GetParts()
        {
            return _parts;
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
