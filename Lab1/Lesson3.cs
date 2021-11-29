using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Lesson3 : LabLesson
    {

        protected override void run()
        {
            for(int i = 100; i < 200; i++)
            {
                if(i % 12 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
