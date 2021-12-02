using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class HinhChuNhat
    {
        private int length;
        private int width;

        public HinhChuNhat()
        {
        }

        public HinhChuNhat(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }

        public int GetArea() {
            return length * width;
        }

        public int GetPerimeter()
        {
            return (length + width) * 2;
        }

        public override string ToString()
        {
            return "Lenght: " + length + ", Width: " + width + ", Area: " + GetArea() + ", Perimeter: " + GetPerimeter();
        }

        public void Show()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
