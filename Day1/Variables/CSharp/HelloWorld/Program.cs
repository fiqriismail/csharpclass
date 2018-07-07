using System;

namespace HelloWorld
{
    class Program
    {
        int number1 = 50;
        static void Main(string[] args)
        {
            //Dont use too short names for variables 
            //Dont use too long names for variables

            int number1 = 20;
            int number2 = 30;

            string output = $"Adding {number1} + {number2} is {number1 + number2}";
            Console.WriteLine(output);
            
            Console.ReadLine();

        }
    }
}
