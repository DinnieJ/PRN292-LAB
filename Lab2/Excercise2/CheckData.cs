using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.Excercise2
{
    class CheckData
    {
        public string CheckString()
        {
            string res = Console.ReadLine();
            while (res == null || res == "")
            {
                Console.WriteLine("Please Re-input: ");
                res = Console.ReadLine();
            }
            return res;
        }

        public int CheckNumber()
        {
            int res = 0;
            try
            {
                res = Int32.Parse(Console.ReadLine());
            } catch(Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                
            }
            return res;
        }
    }
}
