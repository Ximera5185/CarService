﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    internal class Program
    {
        static void Main(string [] args)
        {
            CreatorCar creatorCar = new CreatorCar();   

            Car car = creatorCar.CreateCar();

            car.ShowWorkingParts();
            car.ShowBrokenParts();
        }
    }
}
