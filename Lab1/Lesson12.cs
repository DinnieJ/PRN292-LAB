using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Lesson12
    {
        public Lesson12()
        {
            List<string> stringList = new List<string>();
            Console.WriteLine("Enter string, enter nothing to stop");
            while (true)
            {
                try
                {
                    string n = Console.ReadLine();
                    if (n == "") break;

                    stringList.Add(n);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
            }
            int c_index = 0;
            for(int i = 1; i < stringList.Count; i++)
            {
                if (stringList[c_index].Length < stringList[i].Length) c_index = i;
            }

            Console.WriteLine($"Longest string: {stringList[c_index]}");
        }
    }
}
