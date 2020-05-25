using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class KvUr
    {
        public static double[] Result(double a, double b, double c, out string error)
        {
            error = "";
            if(a == 0)
            {
                if(b == 0)
                {
                    if(c == 0)
                    {
                        error = "R";
                        return new double[0];
                    } 
                    else
                    {
                        error = "Нет корней";
                        return new double[0];
                    }
                }
                else
                {
                    return new double[] { -b / c };
                }
            }
            else
            {
                double D = Math.Pow(b, 2) - 4 * a * c;
                if (D > 0) return new double[] { (-b - Math.Sqrt(D)) / (2 * a), (-b + Math.Sqrt(D)) / (2 * a) };
                else if (D == 0) return new double[] { -b / (2 * a), -b / (2 * a) };
                else
                {
                    error = "Нет корней";
                    return new double[0];
                }
            }
        }
    }
}
