using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlack3
{
    internal class Exercise1
    {
        class Sam
        {
            static int AddNumbers(int num1, int num2)
            {
                return num1 + num2;
            }

            static void Calculater(string[] args)
            {
                int number1 = 5;
                int number2 = 10;

                // Call the AddNumbers function

                int sum = AddNumbers(number1, number2);

                // Print the result to the console

                Console.WriteLine("The sum is: " + sum);

            }
        }
    }
}