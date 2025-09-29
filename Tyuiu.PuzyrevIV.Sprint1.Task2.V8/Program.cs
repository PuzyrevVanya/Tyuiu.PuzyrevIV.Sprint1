using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint1.Task2.V8.Lib;

namespace Tyuiu.PuzyrevIV.Sprint1.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                             *");
            Console.WriteLine("************************************************");

            int x;

            int y;

            Console.WriteLine("Ведение значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ведение значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                   *");
            Console.WriteLine("************************************************");

            Console.WriteLine("Квадрат числа X, Y = " + ds.CalculatePerimetr(x, y));

            Console.ReadLine ();
        }
    }        
}
