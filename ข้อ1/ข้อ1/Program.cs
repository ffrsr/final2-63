using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ข้อ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());            
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());
            int num6 = int.Parse(Console.ReadLine());
            int num7 = int.Parse(Console.ReadLine());
            int num8 = int.Parse(Console.ReadLine());
            int num9 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", num1, num2, num3);
            Console.WriteLine("{0} {1} {2}", num4, num5, num6);
            Console.WriteLine("{0} {1} {2}", num7, num8, num9);

            int input = int.Parse(Console.ReadLine());

            if ( num1 == 0 )
            {
                if ( input == num2 || input == num3 || input == num4 || input == num7 )
                {
                    Console.WriteLine("The number is available");
                }
                else if (input != num2 || input != num3 || input != num4 || input != num7)
                {
                    Console.WriteLine("{0} {1} {2}", input, num2, num3);
                    Console.WriteLine("{0} {1} {2}", num4, num5, num6);
                    Console.WriteLine("{0} {1} {2}", num7, num8, num9);
                }
            }

            else if (num2 == 0)
            {
                if (input == num1 || input == num3 || input == num5 || input == num8)
                {
                    Console.WriteLine("The number is available");
                }
                else if (input != num1 || input != num3 || input != num5 || input != num8)
                {
                    Console.WriteLine("{0} {1} {2}", num1, input, num3);
                    Console.WriteLine("{0} {1} {2}", num4, num5, num6);
                    Console.WriteLine("{0} {1} {2}", num7, num8, num9);
                }
            }

            else if (num3 == 0)
            {
                if (input == num1 || input == num2 || input == num6 || input == num9)
                {
                    Console.WriteLine("The number is available");
                }
                else if (input != num1 || input != num2 || input != num6 || input != num9)
                {
                    Console.WriteLine("{0} {1} {2}", num1, num2, input);
                    Console.WriteLine("{0} {1} {2}", num4, num5, num6);
                    Console.WriteLine("{0} {1} {2}", num7, num8, num9);
                }
            }

            else if (num4 == 0)
            {
                if (input == num1 || input == num7 || input == num5 || input == num6)
                {
                    Console.WriteLine("The number is available");
                }
                else if (input != num1 || input != num7 || input != num5 || input != num6)
                {
                    Console.WriteLine("{0} {1} {2}", num1, num2, num3);
                    Console.WriteLine("{0} {1} {2}", input, num5, num6);
                    Console.WriteLine("{0} {1} {2}", num7, num8, num9);
                }
            }

            else if (num5 == 0)
            {
                if (input == num2 || input == num8 || input == num4 || input == num6)
                {
                    Console.WriteLine("The number is available");
                }
                else if (input != num2 || input != num8 || input != num4 || input != num6)
                {
                    Console.WriteLine("{0} {1} {2}", num1, num2, num3);
                    Console.WriteLine("{0} {1} {2}", num4, input, num6);
                    Console.WriteLine("{0} {1} {2}", num7, num8, num9);
                }
            }

            else if (num6 == 0)
            {
                if (input == num3 || input == num9 || input == num4 || input == num5)
                {
                    Console.WriteLine("The number is available");
                }
                else if (input != num3 || input != num9 || input != num4 || input != num5)
                {
                    Console.WriteLine("{0} {1} {2}", num1, num2, num3);
                    Console.WriteLine("{0} {1} {2}", num4, num5, input);
                    Console.WriteLine("{0} {1} {2}", num7, num8, num9);
                }
            }

            else if (num7 == 0)
            {
                if (input == num1 || input == num4 || input == num8 || input == num9)
                {
                    Console.WriteLine("The number is available");
                }
                else if (input != num1 || input != num4 || input != num8 || input != num9)
                {
                    Console.WriteLine("{0} {1} {2}", num1, num2, num3);
                    Console.WriteLine("{0} {1} {2}", num4, num5, num6);
                    Console.WriteLine("{0} {1} {2}", input, num8, num9);
                }
            }

            else if (num8 == 0)
            {
                if (input == num2 || input == num5 || input == num7 || input == num9)
                {
                    Console.WriteLine("The number is available");
                }
                else if (input != num2 || input != num5 || input != num7 || input != num9)
                {
                    Console.WriteLine("{0} {1} {2}", num1, num2, num3);
                    Console.WriteLine("{0} {1} {2}", num4, num5, num6);
                    Console.WriteLine("{0} {1} {2}", num7, input, num9);
                }
            }

            else if (num9 == 0)
            {
                if (input == num3 || input == num6 || input == num7 || input == num9)
                {
                    Console.WriteLine("The number is available");
                }
                else if (input != num3 || input != num6 || input != num7 || input != num9)
                {
                    Console.WriteLine("{0} {1} {2}", num1, num2, num3);
                    Console.WriteLine("{0} {1} {2}", num4, num5, num6);
                    Console.WriteLine("{0} {1} {2}", num7, num8, input);
                }
            }


            Console.ReadLine();
        }
    }
}
