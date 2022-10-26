using Homework2_More_objects.Classes;
using Homework2_More_objects.Classes.Class2;
using System;

namespace Homework2_More_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class1 class11 = new Class1();

            Class2 class2 = new Class2();
            Class2 class22 = new Class2();

            ClassesInDifferentNamepspace.Class1 classFromOtherNamespace = new ClassesInDifferentNamepspace.Class1();
            var classFromOtherNamespace2 = new ClassesInDifferentNamepspace.Class1();

            Console.WriteLine("Hello World!");
        }
    }
}
