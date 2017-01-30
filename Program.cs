using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n =int.Parse(Console.ReadLine());
            printTriangle(n);
            
        }

        static void printTriangle(int n )
        {
            for (int i = 1; i <= n; i++)
            {
                printTline(i);
            }
            for (int i = n - 1 ; i >=1 ; i--)
            {
                printTline(i);
            }
        }

        static void printTline(int size,int start=1)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine();
        }
    }
}
