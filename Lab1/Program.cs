using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 1 PRN292");
            Console.Write("Select the lesson(1-15): ");
            try
            {
                ExpressionEvaluator.Eval("new Lession10()");
            } catch
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
