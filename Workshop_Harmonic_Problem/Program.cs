using System;

namespace Workshop_Harmonic_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------WELCOME TO THE HARMONIC PROBLEM-----------\n");
            double num1;
            double result = 0;
            Console.WriteLine("Enter the value for the Harmonic value ");
            num1 = double.Parse(Console.ReadLine());
            for(double i=1; i<=num1;i++)
            {
                result = result + 1 / i;
            }
            Console.WriteLine("Harmonic Number of "+num1 + " is " + result);
        }
    }
}
