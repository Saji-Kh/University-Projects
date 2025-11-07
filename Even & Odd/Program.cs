using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even___Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[10];
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                s[i] = int.Parse(Console.ReadLine());
            }

            foreach (int num in s)
            {
                if (num % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine();
            Console.WriteLine("Count of Even numbers: " + evenCount);
            Console.WriteLine("Count of Odd numbers: " + oddCount);

            Console.ReadKey();
        }
    }
}
