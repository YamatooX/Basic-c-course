using HomeworkExcercieses.DataTypes;
using HomeworkExcercieses.IfStatements;
using HomeworkExcercieses.ListsAndLoops;
using HomeworkExcercieses.Namespaces.Namespace1;
using HomeworkExcercieses.Namespaces.Namespace1.Other;
using HomeworkExcercieses.Strings;
using HomeworkExcercieses.UserInteraction;
using HomeworkExcercieses.Generics;
using System;
using System.Collections.Generic;

namespace HomeworkExcercieses
{
    class Program
    {
        static void Main(string[] args)
        {
            var intObj = new Examples<int>();
            intObj.Field = 123;

            var stringObj = new Examples<string>();
            stringObj.Field = "jjk";

            Console.WriteLine(intObj.Field);
            Console.WriteLine(stringObj.Field);

            List<string> slist = new List<string>() { "2", "3" };
            List<int> ilist = new List<int>() { 1, 2, 3 };

            List<object> olist = new List<object>();

            foreach(string s in slist)
            {
                olist.Add(s);
            }
            foreach (int i in ilist)
            {
                olist.Add(i);
            }

            foreach (object o in olist)
            {
                Console.WriteLine(o);
            }
            //Homework1();

            //Homework2();

            //Homework3();

            //Homework4();

            //Homework5();

            //Homework6();
        }

        static double TrapezeArea(float a, float b, float h)
        {
            return ((a + b) * h) / 2;
        }

        static void Homework1()
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

            Console.WriteLine(trapeze.Area);
            Console.WriteLine(trapeze2.Area);
        }

        static void Homework3()
        {
            UserInteractor userInteractor = new UserInteractor();
            userInteractor.Interact();
        }

        static void Homework2()
        {
            Class1 class1 = new Class1();
            var Class2 = new Class2();

            Class1 class11 = new Class1();
        }

        static void Homework4()
        {
            User user = new User(569);            
        }

        static void Homework5()
        {
            ListAndLoop listAndLoop = new ListAndLoop();
            listAndLoop.ListNumbersGreaterThenHunderd();
        }

        static void Homework6() 
        {
            string str = "very long longlong longlong longlong. Really longlong longlong longlong longlong long string";
            ClassWithStrings classWithStrings = new ClassWithStrings();
            Console.WriteLine(classWithStrings.DealWithString(str));
        }
    }
}
