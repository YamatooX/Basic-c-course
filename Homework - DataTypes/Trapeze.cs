
namespace Homework___Data_types
{
    public class Trapeze
    {
        private double a;
        private double b;
        private double h;
        public double area { get; private set; }

        public Trapeze(double a, double b, double h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
            area = CountArea(a, b, h);
        }

        private double CountArea(double a, double b, double h)
        {
            return ((a + b) * h) / 2;
        }
    }
}