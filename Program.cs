#region Task1
namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Area(20, 20);
        }

        static void Area(int r)
        {
            Console.WriteLine(3 * (r * r));

        }

        static void Area(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Area(int a, int b, int c)
        {
            Console.WriteLine(2 * (a * b + a * c + b * c));
        }
        static void Area(double p, double r)
        {
            Console.WriteLine(p * r);
        }

    }
}

#endregion