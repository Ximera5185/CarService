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
            const string ExitProgrammMenu = "2";

            bool isProgrammWork = true;

            string inputUser;

            while (isProgrammWork)
            {
                ShowCars();

                Console.WriteLine($"Для выхода из программы введите {ExitProgrammMenu}");

                inputUser = Console.ReadLine();

                switch (inputUser)
                {
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

        private void ShowCars() 
        {
            Console.WriteLine($"Автомобилей для обслуживания {_cars.Count} штук");
        }
    }
}
