using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Lesson2 : LabLesson
    {
        private bool isPrime(int num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }

                }
                return true;
            }
        }
        protected override void run()
        {
            int c_index = 1;
            int count = 0;
            do
            {
                if (isPrime(c_index))
                    Console.WriteLine($"#{++count}: {c_index}");

                c_index++;
            } while (count < 10);

        }
    }
}
