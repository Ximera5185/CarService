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
            const string SelectCarMenu = "1";

            bool isProgrammWork = true;

            string inputUser;

            while (isProgrammWork)
            {
                Console.WriteLine($"Автомобилей для обслуживания {_cars.Count} штук");
                Console.WriteLine($"Для выбора автомобиля введмте {SelectCarMenu}");
                Console.WriteLine($"Для выхода из программы введите {ExitProgrammMenu}");

                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case SelectCarMenu:
                        ShowCars();
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

        private void ShowCars() 
        {
            
        }

        private void SelectCar() 
        {
            foreach (Car car in _cars)
            {

            }
        }
    }
}
