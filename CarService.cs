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
            Cashier = 0;

            AddCars();
            
            RunSelectMenu();
        }

        private int Cashier { get; set; }

        private void RunSelectMenu() 
        {
            const string SelectCarMenu = "1";
            const string ExitProgrammMenu = "2";

            bool isProgrammWork = true;

            string inputUser;

            while (isProgrammWork)
            {
                Console.Clear();
                Console.WriteLine($"Баланс автосервиса {Cashier}");
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
            int inputUser;
            int monetaryReward = 100;

            Console.Clear();

            _cars[indexCar].ShowBrokenParts();


            Console.WriteLine();

            inputUser = GetUserNumber("Введите порядковый номер детали для ремонта") -1;

            if (_warehouse.GetParts(_cars[indexCar].GetNamePart(inputUser)))
            {
                Console.WriteLine("Заменили деталь");

                _cars [indexCar].RemovePart(inputUser);

                Cashier += monetaryReward;
            }
            else
            {
                Console.WriteLine("Подходящей детали на складе нет");
            }

            if (_cars[indexCar].GetNamePart())
            {
                _cars.RemoveAt(indexCar);
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