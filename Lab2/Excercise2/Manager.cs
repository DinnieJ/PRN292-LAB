using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.Excercise2
{
    class Manager : IManager
    {
        List<Player> players = new List<Player>();
        List<Coach> coaches = new List<Coach>();
        CheckData checker = new CheckData();
        public void ChangePlayer()
        {

            Console.WriteLine("Enter code: ");
            int code = checker.CheckNumber();
            bool isOK = false;
            foreach (var item in players)
            {
                if(item.Code.Equals(code))
                {
                    isOK = true;
                    return;
                }
            }
            if (!isOK) {
                return;
            }
            int shirt = 0;
            int salary = 0;
            Console.WriteLine("Enter option, 0 to change shirt, non-0 to change salary");
            int option = checker.CheckNumber();
            if (option == 0)
            {
                Console.WriteLine("Enter shirt number: ");
                shirt = checker.CheckNumber();
            }
            else
            {
                Console.WriteLine("Enter salary: ");
                salary = checker.CheckNumber();
            }

            for (int i = 0; i < players.Count; i++)
            {
                if(players[i].Code == code)
                {
                    if(option!= 0)
                    {
                        players[i].Salary = salary;
                    } else
                    {
                        players[i].Number = shirt;
                    }
                    break;
                }
            }
        }

        public int CountCoach()
        {
            int cnt = 0;
            foreach (var item in coaches)
            {
                if(item.Year >= 3)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        public void InputCoachList()
        {
            Console.WriteLine("Enter number of coach input: ");
            int n = checker.CheckNumber();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input name: ");
                string name = checker.CheckString();
                Console.WriteLine("Input address ");
                string address = checker.CheckString();
                Console.WriteLine("Input salary");
                int salary = checker.CheckNumber();
                Console.WriteLine("Input position");
                string pos = checker.CheckString();

                Console.WriteLine("Input year experiment");
                int year = checker.CheckNumber();

                int code = 0;
                if (coaches.Count == 0)
                {
                    code = 1;
                }
                else
                {
                    code = coaches.Last().Code + 1;
                }

                coaches.Add(new Coach(code, name, address, salary, year, pos));
            }
        }

        public void InputPlayerList()
        {
            Console.WriteLine("Enter number of player input: ");
            int n = checker.CheckNumber();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Input name: ");
                string name = checker.CheckString();
                Console.WriteLine("Input address ");
                string address = checker.CheckString();
                Console.WriteLine("Input salary");
                int salary = checker.CheckNumber();
                Console.WriteLine("Input position");
                string pos = checker.CheckString();

                Console.WriteLine("Input shirt number");
                int shirt = checker.CheckNumber();

                int code = 0;
                if(players.Count == 0)
                {
                    code = 1;
                }else
                {
                    code = players.Last().Code+1;
                }

                players.Add(new Player(code, name, address, salary, shirt, pos));
            }
        }

        public void ShowCoachList()
        {
            Console.WriteLine("Show Coach List: ");
            foreach(var item in coaches)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void ShowMaxSalary()
        {
            int salaryPlayer = Int32.MinValue;
            foreach (var item in players)
            {
                salaryPlayer = Math.Max(salaryPlayer, item.Salary);
            }
            Console.WriteLine("Show max salary players: ");
            for(int i = 0; i < players.Count; i++)
            {
                if(players[i].Salary == salaryPlayer)
                {
                    Console.WriteLine(players[i].ToString());
                }
            }

            int salaryCoach = Int32.MinValue;
            foreach (var item in coaches)
            {
                salaryCoach = Math.Max(salaryCoach, item.Salary);
            }
            Console.WriteLine("Show max salary players: ");
            for (int i = 0; i < coaches.Count; i++)
            {
                if (coaches[i].Salary == salaryCoach)
                {
                    Console.WriteLine(coaches[i].ToString());
                }
            }
        }

        public void ShowPlayerList()
        {
            Console.WriteLine("Show Player List: ");
            foreach (var item in players)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void SortDescCoach3Year()
        {
            throw new NotImplementedException();
        }

        public void SortPlayerAscendingNumber()
        {
            players.Sort((a, b) => a.Number.CompareTo(b.Number));
        }

        public int SumSalaryStriker()
        {
            int sum = 0;
            foreach (var item in players)
            {
                if(item.Salary.Equals("Striker"))
                {
                    sum += item.Salary;
                }
            }
            return sum;
        }
    }
}
