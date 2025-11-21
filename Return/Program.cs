using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return
{
    internal class Program
    {
            public static double times(double i, double j)
        {
            if (j == 0)
                return 0;
            else
                return i + times(i, j - 1);

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a numbers:");
            double i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a numbers:");
            double j = Convert.ToDouble(Console.ReadLine());
            double h = times(i, j);
            Console.Write("{0} * {1} = {2}", i, j, h);

            Console.ReadKey();
        }
    }
}
