using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Summation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start();
        }

        static void start()
        {
            Console.Write("What do you want to perform?\n[1] Add\n[2] Multply\nAnswer: ");
            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1: add(); break;
                case 2: multiply(); break;
                default: Console.WriteLine("Invalid operation."); break;
            }
        }
        static int summation(int[] x)
        {
            int sum = 0;
            foreach (int i in x)
            {
                sum += i;
            }

            return sum;
        }

        static int multiplication(int[] x)
        {
            int prod = 1;
            foreach (int i in x)
            {
                prod *= i;
            }

            return prod;
        }

        static void add()
        {
            Console.WriteLine("---------\nADDITION\n---------");
            Console.Write("Number to input: ");
            int length = int.Parse(Console.ReadLine());
            int[] num = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum is {summation(num)}");
        }

        static void multiply()
        {
            Console.WriteLine("---------\nMULTIPLICATION\n---------");
            Console.Write("Number to input: ");
            int length = int.Parse(Console.ReadLine());
            int[] num = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The product is {multiplication(num)}");
        }
    }
}
