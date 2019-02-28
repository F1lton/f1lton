using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskWithTeachers
{
    //x + 0.01y == (y + 0.01x - 0.05) / 2
    //x + 0.01y == y/2 + 0.005x - 0.025
    //x + 0.01y - y/2 - 0.005x = -0.025
    //x + 1/100y - 50/100y - 1/200x = -0.025
    //199/200x -49/100y = -0.025
    //0.995x - 0.49y = -0.025
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, res;
            int rozv = 0;
            for (x = 0; x <= 100; x++)
                for (y = 0; y <= 100; y++)
                {                    
                    res = (double)(0.995 * x) - (double)(0.49 * y);
                    if (res >= -0.026 && res <= -0.024)
                    {
                        Console.WriteLine("\n\tx=" + x + ", y=" + y);
                        Console.WriteLine("\t0.995 * " + x + " - 0.49 * " + y + " = " + res);
                        Console.WriteLine("\n\tIts result, dude!(Maybe)!!\n");
                        rozv++;
                    }
                }
            Console.WriteLine("\tCount of calculates: " + rozv);
            Console.ReadKey();
        }
    }
}
