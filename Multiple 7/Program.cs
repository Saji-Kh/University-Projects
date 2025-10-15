using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c, a;
            Console.Write("Enter a number: ");
            a = int.Parse(Console.ReadLine());

            if (a % 7 == 0)
            {
                Console.WriteLine("YES!");
                }
            else
            {
                c = a * 3;
                Console.WriteLine(c);
                Console.ReadKey();
            }
        }
    }
}
