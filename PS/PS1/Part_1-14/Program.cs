using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_14
{
    class Program
    {
        static void Main(string[] args)
        {
        int x = int.Parse(Console.ReadLine());
        int a, b, c, d, e, f, y, z;
        a = x / 100000;
        x = x % 100000;
        b = x / 10000;
        x = x % 10000;
        c = x / 1000;
        x = x % 1000;
        d = x / 100;
        x = x % 100;
        e = x / 10;
        x = x % 10;
        f = x ;
        y = a + b + c;
        z = d + e + f;
        if (y == z)
            Console.WriteLine("Счастливый");
        else Console.WriteLine("Не счастливый");
        Console.ReadLine();
        }
    }
}