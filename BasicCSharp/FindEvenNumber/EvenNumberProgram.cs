using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BasicCSharp.FindEvenNumber
{
    public class EvenNumberProgram
    {
        public void Main()
        {
            int[] numbers = { 10, 15, 20, 25, 30, 35, 40 };
            Console.Write("Array of numbers is: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            FindEvenNumbers(numbers);
        }

        /// <summary>
        /// Find even numbers in an array
        /// </summary>
        /// <param name="numbers">numbers</param>
        public void FindEvenNumbers(int[] numbers)
        {
            Console.Write("Even numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
