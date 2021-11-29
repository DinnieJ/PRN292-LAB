using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab1
{
    class Lesson10
    {
        public Lesson10()
        {
            string fullname = "";

            while(true)
            {
                fullname = Console.ReadLine();

                if (Regex.Split(fullname, @"\s+").Length < 2)
                {
                    Console.WriteLine("invalid input");
                }
                else break;
            }

            string[] splitName = Regex.Split(fullname, @"\s+");

            Console.WriteLine($"First name: {splitName[0]}");
            Console.WriteLine($"Last name: {fullname.Substring(splitName[0].Length)}");
        }
    }
}
