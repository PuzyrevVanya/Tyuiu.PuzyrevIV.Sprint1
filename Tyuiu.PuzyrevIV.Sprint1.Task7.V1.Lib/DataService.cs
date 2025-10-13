using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PuzyrevIV.Sprint1.Task7.V1.Lib
{
    public class DataService : ISprint1Task7V1
    {
        public double Calculate(double a, double b, double c)
        {
            double res = (b + Math.Sqrt((b * b) + (4 * a * c)) / (2 * a) - (a * a * a * c) + Math.Pow(b, -2));
            return res;
        }
    }
}
