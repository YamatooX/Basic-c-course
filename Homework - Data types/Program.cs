using Homework___Data_types;
using System;

namespace Homework1
{
    class Program
    {
        static double trapezeArea(float a, float b, float h)
        {
            return ((a + b) * h) / 2;
        }


        static void Main(string[] args)
        {
            double a = 13;
            double b = 5.0;
            double h = 3.64;

            float f = 54.644F;

            double pole = ((a + b) * h) / 2;
            double poleFromFunc;
            poleFromFunc = trapezeArea(43F, 77F, 12.6433F);

            Console.WriteLine($"{pole} \n {f} \n");
            Console.WriteLine(poleFromFunc);
            int statek = (int)Status.New;
            Status status = Status.InProgress;
            Console.WriteLine($"{status}\n{(int)status}\n{statek}\n");

            Trapeze trapeze = new Trapeze(12.0, 48.4866, 4.865165468);
            Trapeze trapeze2 = new Trapeze(48, 665.999449, 59.556);

            Console.WriteLine(trapeze.area);
            Console.WriteLine(trapeze2.area);
        }

        enum Status
        {
            New = 1,
            InProgress,
            Done = 4,
            Closed = 8
        }
    }
}
