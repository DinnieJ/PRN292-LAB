using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LAB1
{
    class Lesson13 : LabLesson
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
                string[] splitName = Regex.Split(name, @"\s+");
                if (splitName[splitName.Length - 1].ToLower() == "yen") count++;
            });

            Console.WriteLine($"Student first name with \"Yen\": {count}");
        }
    }
}
