using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int k = 0;
            int max = 0;
            while (n != 0)
            {
                if (n % 2 != 0)
                    k = 0;
                if (n % 2 == 0)
                    k++;
                if (max < k)
                    max = k;

                    n = double.Parse(Console.ReadLine());
            }
            if (max == 0)
                Console.WriteLine("Error");
            else
            {
                Console.WriteLine("Количество");
                Console.WriteLine(max);
            }
            Console.ReadKey();
        }
    }
}