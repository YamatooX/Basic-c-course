using Homework___Data_types;
using System;


//  Napisz kod, który będzie liczył pole trapezu i wynik umieszczał w zmiennej pole. 
//  Wartości a, b i h powinny być przypisane do osobnych zmiennych i użyte w równaniu.
//  Dodać enum o nazwie Status i umieść w nim 4 statusy: New, InProgress, Done, Closed. 
//  Przypisz im kolejno wartości: 1, 2, 4, 8. Następnie utwórz zmienną, 
//  do której przypiszesz status InProgress z utworzonego przed chwilą enumu Status.

namespace Homework1
{
    class Program
    {
        static double TrapezeArea(float a, float b, float h)
        {
            return ((a + b) * h) / 2;
        }

        static void Main(string[] args)
        {
            double a = 13;
            double b = 5.0;
            double h = 3.64;

            float f = 54.644F;

            double area = ((a + b) * h) / 2;
            double areaFromFunc = TrapezeArea(43F, 77F, 12.6433F);

            Console.WriteLine($"{area} \n {f} \n");
            Console.WriteLine(areaFromFunc);

            int state = (int)Status.New;
            Status states = Status.InProgress;
            Console.WriteLine($"{states}\n{(int)states}\n{state}\n");

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