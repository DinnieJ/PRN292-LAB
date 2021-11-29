using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Lesson14: LabLesson
    {
        protected override void run()
        {
            List<string> studentsList = new List<string>();
            Console.WriteLine("Enter student name, enter nothing to stop");
            while (true)
            {
                try
                {
                    string n = Console.ReadLine();
                    if (n == "") break;

                    studentsList.Add(n);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
            }

            int count = 0;
            studentsList.ForEach(delegate (string name)
            {
                if (name.ToLower().Contains("van")) count++;
            });

            Console.WriteLine($"Student name have \"Van\": {count}");
        }
    }
}
