﻿using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    internal class UserUtils
    {
        private static Random s_random = new Random();

        public static int GetRandomNumber(int maxValue)
        {
            return s_random.Next(maxValue);
        }

        public static int GetRandomNumber(int minValue, int maxValue)
        {
            return s_random.Next(maxValue);
        }
    }
}
