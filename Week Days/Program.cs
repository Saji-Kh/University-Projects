using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_Days
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a;
            Console.Write("Enter a number: ");
            a = int.Parse(Console.ReadLine());
            Console.Clear();
            if (a < 8)
            {
                switch (a)
                {
                    case 1:
                        {

                            Console.WriteLine("Saturday");
                            break;
                        }
                    case 2:
                        {

                            Console.WriteLine("Sunday");
                            break;
                        }
                    case 3:
                        {

                            Console.WriteLine("Monday");
                            break;
                        }
                    case 4:
                        {

                            Console.WriteLine("Tuesday");
                            break;
                        }
                    case 5:
                        {

                            Console.WriteLine("Wednesday");
                            break;
                        }
                    case 6:
                        {

                            Console.WriteLine("Thursday");
                            break;
                        }
                    case 7:
                        {

                            Console.WriteLine("Friday");
                            break;

                        }
                }
            }
            else
            {
                Console.WriteLine("END!");
            }
            Console.ReadKey();
        }
    }
}
