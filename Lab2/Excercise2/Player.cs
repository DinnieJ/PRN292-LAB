using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.Excercise2
{
    class Player : Staff
    {
        private int number;
        

        public Player()
        {
        }

        public Player(int code, string name, string address, int salary, int number, string position)
        {
            base.code = code;
            base.name = name;
            base.address = address;
            base.salary = salary;
            base.position = position;

            this.number = number;
            
        }

        public int Number { get => number; set => number = value; }

        public override string ToString()
        {
            return base.ToString() + ", Number: " + number;
        }
    }
}
