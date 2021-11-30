using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    abstract class LabLesson
    {
       public LabLesson()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine($"Running {this.GetType().Name}: ");
            this.run();
            watch.Stop();
            Console.WriteLine($"{this.GetType().Name} end after {watch.ElapsedMilliseconds} ms\n");
        }
       protected abstract void run();
    }
}
