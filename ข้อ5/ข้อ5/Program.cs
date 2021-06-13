using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ข้อ5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPocket = int.Parse(Console.ReadLine());
            
            for ( int i = 1; i <= numPocket; i++)
            {
                string nameItem = Console.ReadLine();
                string[] newnameitem = new string[i];
                string typeItem = Console.ReadLine();
                string[] newtypeitem = new string[i];


                string mode = Console.ReadLine();

                if (mode == "ShowAll")
                {
                    for (i = 1; i <= numPocket; i++)
                    {
                        Console.WriteLine(newnameitem[i]);
                        Console.WriteLine(newtypeitem[i]);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("End");
                }

            }

            
            Console.ReadLine();
        }
    }
}
