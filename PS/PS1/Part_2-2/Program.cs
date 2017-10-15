using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            k = a + (b - a) * (k - 1);
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}