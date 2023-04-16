using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage274
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Employee Wage Computation Program");
           Wage wage = new Wage();
            wage.CalculateWage();
        }
    }
}
