using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement
{

    internal class Maths
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            while (b == 0)
            {
                Console.WriteLine("You cannot divide by zero enter another number:");
                while (!int.TryParse(Console.ReadLine(), out b) || b == 0)
                {
                    Console.WriteLine("Invalid input.  enter a valid number other than zero:");
                }
            }
            return (double)a / b;
        }
    }
}
