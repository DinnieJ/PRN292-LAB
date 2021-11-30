using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Lesson1 : LabLesson
    {
        private bool checkComposite(int num)
        {
            int count = 0;
            for(int i = 1; i <= num; i++)
            {
                if (count > 2) return true;
                if (num % i == 0) count++;
            }

            return count > 2;
        }
        protected override void run()
        {
            for(int i = 1;i < 100;i ++)
            {
                if (checkComposite(i)) Console.WriteLine(i);
            }
        }
    }
}
