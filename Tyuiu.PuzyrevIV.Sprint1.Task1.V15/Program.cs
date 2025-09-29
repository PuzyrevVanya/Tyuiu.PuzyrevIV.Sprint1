using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint1.Task1.V15.Lib;

namespace Tyuiu.PuzyrevIV.Sprint1.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Пузырёв И. В. | СМАРТб 25-1";
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* Спринт #1                                              *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях*");
            Console.WriteLine("* Задание #1                                             *");
            Console.WriteLine("* Вариант #15                                            *");
            Console.WriteLine("* Выполнил: Пузырёв Иван Вадимович СМАРТб 25-1           *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                               *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя *");
            Console.WriteLine("* исходные данные, вычисляет по формуле (4 + 2 * x) / 7  *");
            Console.WriteLine("* и печатает его на экране                               *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                       *");
            Console.WriteLine("**********************************************************");

            double x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                              *");
            Console.WriteLine("**********************************************************");

            Console.WriteLine(ds.Calculate(x));

            Console.ReadLine();
        }
    }
}
    
