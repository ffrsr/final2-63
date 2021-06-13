using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ข้อ3
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string inputNum;
            
            do
            {
                 inputNum = Console.ReadLine();
                
            } while (inputNum != "End");

            string mode;
            do
            {

                mode = Console.ReadLine();

                if (mode == "FindMax")
                {
                   
                }

                else if (mode == "FindMin")
                {

                }

                else if (mode == "FindMean")
                {
                    
                    
                }

                else
                {
                    Console.WriteLine("Invalid mode");
                }
            } while (mode != "FindMax" || mode != "FindMin" || mode != "FindMean");

            Console.ReadLine();
        }

    }
}
