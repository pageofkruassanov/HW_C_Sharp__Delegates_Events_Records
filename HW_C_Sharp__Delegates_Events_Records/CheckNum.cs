﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_C_Sharp__Delegates_Events_Records
{
    public static class CheckNum
    {

        public static bool IsPair(int number)
        {
            return (number % 2 == 0);
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false; 
            }

            if (number <= 3)
            {
                return true; 
            }

            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsFibonacci(int number)
        {
            if (number < 0)
            {
                return false;
            }

            int a = 0;
            int b = 1;

            while (a < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a == number;
        }
    }
}
