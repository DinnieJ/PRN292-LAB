
using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Lab 1 PRN292");
                Console.Write("Select the lesson(1-15), q to quit: ");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "1": new Lesson1();break;
                    case "2": new Lesson2();break;
                    case "3": new Lesson3();break;
                    case "4": new Lesson4();break;
                    case "5": new Lesson5(); break;
                    case "6": new Lesson6(); break;
                    case "7": new Lesson7(); break;
                    case "8": new Lesson8(); break;
                    case "9": new Lesson9(); break;
                    case "10": new Lesson10(); break;
                    case "11": new Lesson11(); break;
                    case "12": new Lesson12(); break;
                    case "13": new Lesson13(); break;
                    case "14": new Lesson14(); break;
                    case "15": new Lesson15(); break;
                    case "q": return;
                }
            }
        }
    }
}
