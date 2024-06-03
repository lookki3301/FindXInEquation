using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadroX
{
    public class FindDiscr
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Discr(1, 6, 9)[0]);
        }

        public static List<double> Discr(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            if (d < 0) { return new List<double> { 0, 0 }; }

            else
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);

                return new List<double> { -x1, -x2 };
            }
        }
    }
}
