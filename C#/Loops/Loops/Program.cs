using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForeachLoop();

            bool primeNumber;
            int N;
            Console.WriteLine("Write the number you want to query for primality:");
            N = Convert.ToInt32(Console.ReadLine());
            primeNumber = IsPrimeNumber(N);

            if(primeNumber)
                Console.WriteLine("It is a prime number");
            else
                Console.WriteLine("It is NOT a prime number");

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }  
            }
            return result;
        }

        private static void ForeachLoop()
        {
            string[] students = new string[3] { "Ahmet", "Salih", "Ayşe" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Finished");
        }

        private static void ForLoop()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
        }
    }
}
