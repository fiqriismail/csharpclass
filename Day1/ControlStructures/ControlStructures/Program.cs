using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            bool printFirst3 = false;

            if (printFirst3 == true)
            {
                Console.WriteLine(1);
                Console.WriteLine(2);
                Console.WriteLine(3);
            }
            else
            {
                Console.WriteLine(4);
                Console.WriteLine(5);
                Console.WriteLine(6);
            }

            // More ifs 
            int passMarks = 85;
            string output = passMarks >= 85 ? "PASS" : "FAIL";

            Console.WriteLine(output);

            bool isPass = passMarks > 60;

            Console.WriteLine(isPass);

            Console.ReadLine();
        }
    }
}
