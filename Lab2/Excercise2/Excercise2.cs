using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.Excercise2
{
    class Excercise2
    {
        public void Run()
        {
            CheckData checker = new CheckData();
            IManager manager = new Manager();
            while (true)
            {
                Console.WriteLine("Excercise 2:");
                Console.WriteLine("1. Input list players");
                Console.WriteLine("2. Input list coaches");
                Console.WriteLine("3. Show list players");
                Console.WriteLine("4. Show list coaches");
                Console.WriteLine("5. Update players");
                Console.WriteLine("6. Count the coaches that have years of experience >=3");
                Console.WriteLine("7. Sum of the salary of the players that are the striker");
                Console.WriteLine("8. Show max salary");
                Console.WriteLine("9. Sort list player by shirt");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Choose your option: ");
                int option = checker.CheckNumber();
                switch (option)
                {
                    case 1:
                        {
                            manager.InputPlayerList();
                            break;
                        }
                    case 2:
                        {
                            manager.InputCoachList();
                            break;
                        }
                    case 3:
                        {
                            manager.ShowPlayerList();
                            break;
                        }
                    case 4:
                        {
                            manager.ShowCoachList();
                            break;
                        }
                    case 5:
                        {

                            manager.ChangePlayer();
                            break;
                        }
                    case 6:
                        {
                            manager.CountCoach();
                            break;
                        }
                    case 7:
                        {
                            manager.SumSalaryStriker();
                            break;
                        }
                    case 8:
                        {
                            manager.ShowMaxSalary();
                            break;
                        }
                    case 9:
                        {
                            manager.SortPlayerAscendingNumber();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Goodbye!!");
                            return;
                        }
                }
            }
        }
    }
}
