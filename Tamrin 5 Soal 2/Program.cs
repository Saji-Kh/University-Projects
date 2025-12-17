using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Tamrin
{
    internal class Program
    {
            public static double times(double x, double y)
        {
            if (y == 0)
                return 0;
            else
                return x + times(x, y - 1);

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a numbers:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a numbers:");
            double y = Convert.ToDouble(Console.ReadLine());
            double z = times(x, y);
            Console.Write("{0} * {1} = {2}", x, y, z);

            Console.ReadKey();
        }
    }
}
