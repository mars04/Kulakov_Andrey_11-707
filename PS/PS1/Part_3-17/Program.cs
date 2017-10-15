using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_17
{
    class Program
    {
        static void Main(string[] args) { 
        Console.Write("Введите конец диапазона от 2 до : ");
        int n = int.Parse(Console.ReadLine());
            int k = 0;
            int s = 0;
        for(int i=2; i<=n; i++)
            {
        for(int j=2; j<i; j++)
                {
                    if (i % j == 0)
                       k++;
                    
                }
                if (k == 0)
                    s++;
                else k = 0;

            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
  
       
    }
}
