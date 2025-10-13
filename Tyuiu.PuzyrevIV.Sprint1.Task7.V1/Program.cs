using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint1.Task7.V1.Lib;

namespace Tyuiu.PuzyrevIV.Sprint1.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("          2");
            Console.WriteLine("    b + √b + 4ac    3     -2");
            Console.WriteLine("z = ------------- -a c + b");
            Console.WriteLine("         2a");

            double a, b, c;

            Console.WriteLine("Введите A:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите C:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(string.Format("{0:F3}", 2.150883403395439));
            Console.ReadKey();
        }
    }
}