using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Sum2(2, 5);

            int number1 = 20;
            int number2 = 100;
            var result2 = Sum2(number1, number2);
            var result3 = Sum3(ref number1, number2);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            Console.WriteLine(number1);

            Console.WriteLine(Multiply(number1, number2));
            Console.WriteLine(Multiply(number1, number2, 2));

            Console.WriteLine(Sum4(1,5,6,10,7,number2));

            Console.ReadLine();

        }

        static void Sum()
        {
            Console.WriteLine("Toplandı!");
        }

        static int Sum2(int number1 = 0, int number2 = 0)
        {
            return number1 + number2;
        }
        static int Sum3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Sum4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
