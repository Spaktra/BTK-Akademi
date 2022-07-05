using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Ahmet";
            students[1] = "Altay";
            students[2] = "Ayşenur";

            string[] students2 = new[] {"Ahmet", "Altay", "Ayşenur"};

            string[] students3 ={ "Ahmet", "Altay", "Ayşenur" };

            foreach (var student in students3)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            string[,] regions = new string[5, 3]
            {
                {"İstanbul", "İzmit","Balıkesir" },
                {"Ankara", "Konya", "Kırıkkale" },
                { "Antalya", "Adana", "Mersin" },
                { "Rize", "Trabzon", "Mersin" },
                { "İzmir", "Muğla", "Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0) ; i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("---------------");
            }

            Console.ReadKey();
        }
    }
}
