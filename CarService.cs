using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    internal class CarService
    {
        private CreatorCar _creatorCar = new CreatorCar();

        private List<Car> _cars = new List<Car>();

        private Warehouse _warehouse = new Warehouse();

        public CarService() 
        {
            AddCars();
            
            RunSelectMenu();
        }

        private void RunSelectMenu() 
        {
            const string SelectCarMenu = "1";
            const string ExitProgrammMenu = "2";

            bool isProgrammWork = true;

            string inputUser;

            while (isProgrammWork)
            {
                Console.WriteLine($"Автомобилей для обслуживания {_cars.Count} штук");
                Console.WriteLine($"Для выбора автомобиля введите {SelectCarMenu}");
                Console.WriteLine($"Для выхода из программы введите {ExitProgrammMenu}");

                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case SelectCarMenu:
                        SelectCar();
                        break;
                    case ExitProgrammMenu:
                        isProgrammWork = false;
                        break;
                }
            }
        }

        private void AddCars()
        {
            int maxValueCars = 4;

            for (int i = 0; i < maxValueCars; i++)
            {
                _cars.Add(_creatorCar.Create());
            }
        }

        private void SelectCar() 
        {
            int index = 1;
            int inputUser;

            Console.Clear();
            Console.WriteLine("Введите порядковый номер автомобиля для его выбора");

            foreach (Car car in _cars)
            {
                Console.WriteLine($"{index} {car.Name}");

                index++;
            }

            inputUser = Convert.ToInt32(Console.ReadLine());

            RepairCar(inputUser);
        }

        private void RepairCar(int indexCar) 
        {
            Console.Clear();

            _cars[indexCar -1].ShowBrokenParts();

            int inputUser;

            Console.WriteLine("Введите порядковый номер детали для ремонта");

            inputUser = Convert.ToInt32(Console.ReadLine());

            if (_warehouse.GetParts(_cars[indexCar - 1].GetNamePart(inputUser - 1)))
            {
                Console.WriteLine("Заменили деталь");

                _cars [indexCar - 1].RemovePart(inputUser - 1);
            }
            else
            {
                Console.WriteLine("Подходящей детали на складе нет");
            }
        }
    }
}
