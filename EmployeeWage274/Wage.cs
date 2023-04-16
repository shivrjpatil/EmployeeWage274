﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage274
{
    internal class Wage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int WAGE_PER_HOUR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HOURS = 100;
        public void CalculateWage()
        {
            int empwage = 0, emphrs = 0, day = 1, totalwage = 0, totalhour = 0;

            Random random = new Random();

            while (day <= MAX_WORKING_DAYS && totalhour <= MAX_WORKING_HOURS)
            {
                int EmpCheck = random.Next(0, 3);
                switch (EmpCheck)
                {

                    case FULL_TIME:
                        emphrs = 8;
                        break;

                    case PART_TIME:
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                empwage = WAGE_PER_HOUR * emphrs;
                totalwage += empwage;
                totalhour += emphrs;
                day++;
            }
            Console.WriteLine("Toatl wage for {0} days:{1} and hour is {2}", (day - 1), totalwage, totalhour);
            Console.ReadLine();
        }
    }
}
