using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ข้อ6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] save;
            save = new string[5];

            menu();
            int input; 

            do
            {
                string namefile;
                input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    Console.WriteLine("[0] {0}");
                    Console.WriteLine("[1] {0}");
                    Console.WriteLine("[2] {0}");
                    Console.WriteLine("[3] {0}");
                    Console.WriteLine("[4] {0}");
                }

                else if (input == 1)
                {
                    namefile = Console.ReadLine();
                    menu();
                    
                }


                else if (input == 2)
                {
                    int num = int.Parse(Console.ReadLine());
                }

                
                else
                {
                    Console.WriteLine("Invalid menu number");
                    menu();
                }

            } while (input != 0 || input != 1 || input != 2);
            Console.ReadLine();
        }

        static void menu()
        {
            Console.WriteLine("Please input a number from 0 - 3 to choose the following menu:");
            Console.WriteLine("[0] Show all recent files");
            Console.WriteLine("[1] Open new fil");
            Console.WriteLine("[2] Open recent fil");
            Console.WriteLine("[3] Exit");
        }
    }
}
