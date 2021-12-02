using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.Excercise2
{
    class Coach : Staff
    {
        private int year;

        public Coach()
        {
        }

        public Coach(int code, string name, string address, int salary, int year, string position)
        {
            base.code = code;
            base.name = name;
            base.address = address;
            base.salary = salary;
            base.position = position;

            this.year = year;
        }

        public int Year { get => year; set => year = value; }

        public override string ToString()
        {
            return base.ToString() + ", Year: " + year;
        }
    }
}
