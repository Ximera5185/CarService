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
            Console.WriteLine();

            foreach (Car car in _cars)
            {
                Console.WriteLine($"{index} {car.Name}");

                index++;
            }

            inputUser = GetUserNumber("Введите порядковый номер автомобиля для его выбора") - 1;

            RepairCar(inputUser);
        }

        private void RepairCar(int indexCar) 
        {
            Console.Clear();

            _cars[indexCar].ShowBrokenParts();

            int inputUser;

            Console.WriteLine();

            inputUser = GetUserNumber("Введите порядковый номер детали для ремонта") -1;

            if (_warehouse.GetParts(_cars[indexCar].GetNamePart(inputUser)))
            {
                Console.WriteLine("Заменили деталь");

                _cars [indexCar].RemovePart(inputUser);
            }
            else
            {
                Console.WriteLine("Подходящей детали на складе нет");
            }
        }

        private int GetUserNumber(string message)
        {
            int number = 0;

            string input = "";

            while (int.TryParse(input, out number) == false)
            {
                Console.WriteLine(message);

                input = Console.ReadLine();

                Console.WriteLine("Вы ввели не целое число.");
            }

            return number;
        }
    }
}
