using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    abstract class LabLesson
    {
       public LabLesson()
        {
            this.run();
        }
       protected abstract void run();
    }
}
