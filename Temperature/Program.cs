using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sajad_Khorsandi_Temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double C, F;
            Console.Write("Enter a temp (C): ");
            C = Double.Parse(Console.ReadLine());


            F = C * 1.8 + 32;

            Console.WriteLine( F );
            Console.ReadKey();
        }
    }
}