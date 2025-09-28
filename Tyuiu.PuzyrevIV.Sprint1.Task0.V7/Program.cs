using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint1.Task0.V7.Lib;

namespace Tyuiu.PuzyrevIV.Sprint1.Task0.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Пузырёв И. В. | СМАРТб 25-1";
            Console.WriteLine("******************************************************");
            Console.WriteLine("* Спринт #1                                          *");
            Console.WriteLine("* Тема: Базовые навыки в работы в C#                 *");
            Console.WriteLine("* Задание #0                                         *");
            Console.WriteLine("* Вариант #7                                         *");
            Console.WriteLine("* Выполнил: Пузырёв Иван Вадимович СМАРТб 25-1       *");
            Console.WriteLine("******************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                           *");
            Console.WriteLine("******************************************************");
            Console.WriteLine("* Написать программу, которая вычисляет выражение    *");
            Console.WriteLine("* 18 / 6 * 2 - (4 - 3) и печатает результат на экране*");
            Console.WriteLine("******************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                   *");
            Console.WriteLine("******************************************************");
            Console.WriteLine("* 18 / 6 * 2 - (4 - 3)                               *");
            Console.WriteLine("******************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                          *");
            Console.WriteLine("******************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}