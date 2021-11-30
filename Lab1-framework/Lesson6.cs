using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    class Lesson6 : LabLesson
    {
        protected override void run()
        {
            int n;

            try
            {
                List<int> factor = new List<int>();
                n = Int32.Parse(Console.ReadLine());
                
                for (int i = 2; i <= n; i++)
                {
                    while (n % i == 0)
                    {
                        factor.Add(i);
                        n /= i;
                    }
                }
                IEnumerable<int> ls = factor;
                Console.Write("-->" + String.Join(",", (string[])ls.Select(i => i.ToString())));
            } catch (Exception e)
            {
                Console.WriteLine("Invalid input");
                return;
            }
        }
    }
}
