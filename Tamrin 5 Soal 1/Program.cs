using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            double r = double.Parse(Console.ReadLine());
            Mohit(r);
            Console.WriteLine("Mashat is " + Masahat(r) + "\n");

        }
        public static void Mohit(double r)
        {
            double m = 2 * 3.14 * r;
            Console.WriteLine("Mohit {0} is {1}", r, m);
        }
        public static double Masahat(double r)
        {
            double pi = 3.14;
            double m = pi * Math.Pow(r, 2);
            return m;
        }
    }
    }

