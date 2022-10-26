using System;

namespace Homework1
{
    class Program
    {
        // Learning data types
        // Not including functions

        /*  
         *  Napisz kod, który będzie liczył pole trapezu i wynik umieszczał w zmiennej pole. 
            Wartości a, b i h powinny być przypisane do osobnych zmiennych i użyte w równaniu.
            Dodać enum o nazwie Status i umieść w nim 4 statusy: New, InProgress, Done, Closed. 
            Przypisz im kolejno wartości: 1, 2, 4, 8. Następnie utwórz zmienną, 
            do której przypiszesz status InProgress z utworzonego przed chwilą enumu Status.
        */
        static double trapeze(float a, float b, float h)
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
            poleFromFunc = trapeze(43F, 77F, 12.6433F);

            Console.WriteLine($"{pole} \n {f} \n");
            Console.WriteLine(poleFromFunc);
            int statek = (int)Status.New;
            Status status = Status.InProgress;
            Console.WriteLine($"{status}\n{(int)status}\n{statek}");
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
