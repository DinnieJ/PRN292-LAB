using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Lesson9
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

        public Lesson9()
        {
            List<int> numsList = new List<int>();
            Console.WriteLine("Enter numbers, enter 0 to stop");
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

            int countPrime = 0;
            numsList.ForEach(delegate (int num)
            {
                if (isPrime(num)) countPrime++;
            });

            Console.WriteLine("No of Prime Num(s): " + countPrime);
            Console.WriteLine("No of Composite Num(s): " + (numsList.Count - countPrime));
        }

    }
}
