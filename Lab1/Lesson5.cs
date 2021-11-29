using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Lesson5 : LabLesson
    {
        protected override void run()
        {
            int count = 0;
            for(int i = 0; i <= 100; i++)
            {
                if(i%5 == 0 || i%5 == 2)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
