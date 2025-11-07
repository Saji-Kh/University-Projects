using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Exists_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[5];
            bool found = false;
            int position = -1;


            for (int i = 0; i < s.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                s[i] = int.Parse(Console.ReadLine());

                if (s[i] == 2)
                {
                    found = true;
                    position = i + 1;
                }
            }

            Console.WriteLine();

            if (found)
                Console.WriteLine($"Number 2 Found at position {position}.");
            else
                Console.WriteLine("Number 2 not found.");

            Console.ReadKey();
        }
    }
}
