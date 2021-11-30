using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    abstract class LabLesson
    {
       public LabLesson()
        {
            Console.WriteLine($"Running {this.GetType().Name}: ");
            this.run();
        }
       protected abstract void run();
    }
}
