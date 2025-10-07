using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint1.Task3.V8.Lib;

namespace Tyuiu.PuzyrevIV.Sprint1.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                             *");
            Console.WriteLine("************************************************");

            double StartAmount = 2500;
            double TymeDays = 30;
            double Percent = 20;
            double result = 41.10;

            Console.WriteLine($"Величина вклада: {StartAmount} руб.");
            Console.WriteLine($"Срок вклада: {TymeDays} дней");
            Console.WriteLine($"Процентная ставка: {Percent}% годовых");

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine($"Доход: {result} руб.");
            Console.WriteLine("Сумма по окончании срока вклада {0}", result + StartAmount);

            Console.ReadLine();
        }
    }
}