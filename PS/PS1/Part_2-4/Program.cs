using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        int f = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int k;
        //n = f + s · (k - 1) 
        k = (n - f) / s + 1;
        if ((n - f) % s != 0)
            Console.WriteLine("-1");
        else
            Console.WriteLine(k);
        Console.ReadLine();
        }
    }
}