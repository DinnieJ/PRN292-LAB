using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LAB1
{
    class Lesson8
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
        public Lesson8()
        {
            List<int> numsList = new List<int>();
            Console.WriteLine("Enter numbers, enter -1 to stop");
            while (true)
            {
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == -1) break;

                    numsList.Add(n);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
            }
            numsList.ForEach(delegate (int num)
            {
                if (isPrime(num)) numsList.Remove(num);
            });

            IEnumerable<int> ls = numsList;

            Console.WriteLine("Prime numbers: " + String.Join(", ", (string[])ls.Select(item => item.ToString())));
        }
    }
}
