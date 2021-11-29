using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Lesson4 : LabLesson
    {
        private bool checkPerfectNum(int num)
        {
            int sum = 0;
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0) sum += i;
            }

            return sum == num;
        } 
        protected override void run()
        {
            int count = 0;
            int c_index = 1;

            while(count < 4)
            {
                if(this.checkPerfectNum(c_index))
                {
                    Console.WriteLine(c_index);
                    count++;
                }
                c_index++;
            };
        }
    }
}
