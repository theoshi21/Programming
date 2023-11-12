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
            add();
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

        static void add()
        {
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
    }
}
