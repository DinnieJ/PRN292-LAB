using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.Excercise1
{
    class Excercise1
    {
        public void Run()
        {
            HinhChuNhat hcn = new HinhChuNhat();
            int l = Convert.ToInt32(Console.ReadLine());
            int w = Convert.ToInt32(Console.ReadLine());
            hcn.Length = l;
            hcn.Width = w;

            hcn.Show();
        }
    }
}
