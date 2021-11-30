using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Lesson11: LabLesson
    {
        protected override void run()
        {
            string s = "010101000010001";

            string c_s = "";

            Console.WriteLine($"Current String: {s}");

            foreach(char c in s)
            {
                if (c == '0') c_s += '1';
                else c_s += 0;
            }

            Console.WriteLine($"Converted String: {c_s}");
            
        }
    }
}
