﻿using System;
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

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if ((a + b) <= c)
            Console.WriteLine("No");
        else
        if ((a + c) <= b)
            Console.WriteLine("No");
        else
        if ((b + c) <= a)
            Console.WriteLine("No");
        else
            Console.WriteLine("Yes");
        Console.ReadLine();

        }
    }
}