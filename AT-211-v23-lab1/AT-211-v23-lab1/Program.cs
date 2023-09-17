using System;

namespace AT_211_v23_lab1
{
    internal class Program
    {
        static void Main()
        {
            //START
            Console.WriteLine("TASK 1\n");
            string bufer;

            //Create and Input number 1
            Console.Write("Enter number 1 >> ");
            bufer = Console.ReadLine();
            double number1 = Convert.ToDouble(bufer);

            //Create and Input number 2
            Console.Write("Enter number 2 >> ");
            bufer = Console.ReadLine();
            double number2 = Convert.ToDouble(bufer);

            Console.WriteLine("===============");

            //Create and calculate result, write answer
            double result =Math.Pow((number1+number2),3);
            Console.WriteLine($"Result >>  ({number1} + {number2})^3 = {result}");
        }
    }
}