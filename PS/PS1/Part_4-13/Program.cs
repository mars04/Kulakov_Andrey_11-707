
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            double l;
            double n = double.Parse(Console.ReadLine());
            k = 0;
            while (n != 0)
            {
                l = Math.Sqrt(n);
                l = Math.Truncate(l);
                n = n - l * l;
                k++;
            }
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}