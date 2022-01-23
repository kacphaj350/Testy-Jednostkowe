using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rownanie
{
    public class Równanie
    {
        public (double,double) Mzerowe(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;

            if(delta > 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                return (x1, x2);
            }
            else if(delta == 0)
            {
                double x = -b / (2 * a);
                return (x, x);
            }
            else
            {
                return (double.NaN,double.NaN);
            }
        }
    }
}
