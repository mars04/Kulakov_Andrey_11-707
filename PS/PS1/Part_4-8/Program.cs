using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d,n,s;
            s = 0;
            for (int i = 1000; i < 10000; i++)
            {
                n = i;
                a = n / 1000;
                n = n % 1000;
                b = n / 100;
                n = n % 100;
                c = n / 10;
                n = n % 10;
                d = n;
                if (i == a * a * a * a + b * b * b * b + c * c * c * c + d * d * d * d)
                    s = s + i;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
