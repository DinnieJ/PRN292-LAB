using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Lesson7 : LabLesson
    {
        protected override void run()
        {
            List<int> numsList = new List<int>();
            Console.WriteLine("Enter numbers, enter 0 to stop");
            while(true)
            {
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 0) break;

                    numsList.Add(n);
                } catch (Exception e)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
            }

            numsList.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine("Sorted: " + String.Join(',', numsList.ToArray()));
        }
    }
}
