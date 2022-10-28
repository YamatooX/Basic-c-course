//  Napisz kod, który będzie liczył pole trapezu i wynik umieszczał w zmiennej pole. 
//  Wartości a, b i h powinny być przypisane do osobnych zmiennych i użyte w równaniu.
//  Dodać enum o nazwie Status i umieść w nim 4 statusy: New, InProgress, Done, Closed. 
//  Przypisz im kolejno wartości: 1, 2, 4, 8. Następnie utwórz zmienną, 
//  do której przypiszesz status InProgress z utworzonego przed chwilą enumu Status.

//Wróć do kodu z punktu pierwszego poprzedniej pracy domowej (z modułu nr 5).
//Dodaj w nim nową klasę, a w tej klasie dodaj pola, które będą zawierać wartości dla a, b i h.
//Zamień zmienne z danymi z poprzednio napisanego kodu, na obiekt tej klasy, do pól tego obiektu przypiszesz wcześniejsze dane trapezu i użyj tych pól w równaniu.


namespace HomeworkExcercieses.DataTypes
{
    class Trapeze
    {
        private double a;
        private double b;
        private double h;
        public double _area;
        public double Area {
            get
            {
                return _area;
            }
            private set
            {
                _area = value;
            }
        }

        public Trapeze(double a, double b, double h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
            _area = CountArea(a, b, h);
        }

        private double CountArea(double a, double b, double h)
        {
            return ((a + b) * h) / 2;
        }
    }
    enum Status
    {
        New = 1,
        InProgress,
        Done = 4,
        Closed = 8
    }
}
