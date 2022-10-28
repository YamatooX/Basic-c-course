using ObjectsAndNamespaces.Classes;
using ObjectsAndNamespaces.Classes.Other;
using ObjectsAndNamespaces.ClassesInDifferentNamepspace;
using System;


// Utwórz nowy projekt, w którym dodasz 3 nowe klasy. Dwie klasy powinny być w tej samej przestrzeni nazw ale innej niż przestrzeń nazw w jakiej jest klasa
// Program z pliku Program.cs. Trzecia klasa ma mieć taką samą nazwę jak jedna z poprzednich ale znajdować się w innej przestrzeni nazw.
// Utwórz po dwa obiekty każdej z klas, które utworzyłeś w poprzednim punkcie.
// Zmień przestrzeń nazw jednej z wcześniej utworzonych klas bez przenoszenia jej w inne miejsce. Dostosuj program tak aby udało się go uruchomić bez błędów.

namespace Homework2_More_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectsAndNamespaces.Classes.Other.Class1 class1 = new ObjectsAndNamespaces.Classes.Other.Class1();
            var class11 = new ObjectsAndNamespaces.Classes.Other.Class1();

            Class2 class2 = new Class2();
            var class22 = new Class2();

            ObjectsAndNamespaces.ClassesInDifferentNamepspace.Class1 classFromOtherNamespace = new ObjectsAndNamespaces.ClassesInDifferentNamepspace.Class1();
            var classFromOtherNamespace2 = new ObjectsAndNamespaces.ClassesInDifferentNamepspace.Class1();

            Console.WriteLine("Hello World!");
        }
    }
}
