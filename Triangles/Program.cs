using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;

namespace Triangles
{
    internal class Program
    {
        delegate double Function (double x);

        class Multiplier 
        {
            double _factor;
            public Multiplier(double factor)
            {
                _factor = factor;
            }
            public double Multiply(double x) => x * _factor;

        }

        class DelegateExample
        {
            public static double[] Apply(double[] a, Function f)
            {
                var res = new double[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    res[i] = f(a[i]);
                }
                return res;
            }



            static void Main(string[] args)
            {
                double[] a = { 0.0, 0.5, 1.0 };

                double[] sqaures = Apply(a, (x) => x * x);
                double[] sines = Apply(a, Math.Sin);
                Multiplier m = new(2.0);
                double[] doubles = Apply(a, m.Multiply);
                Console.WriteLine(a);
            }
        }

    }
}