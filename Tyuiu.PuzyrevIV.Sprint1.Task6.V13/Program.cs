using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint1.Task6.V13.Lib;

namespace Tyuiu.PuzyrevIV.Sprint1.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                             *");
            Console.WriteLine("************************************************");

            Console.WriteLine("Введите строку:");
            string value = Console.ReadLine();

            Console.WriteLine("************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                   *");
            Console.WriteLine("************************************************");

            Console.WriteLine(ds.CheckWordsAlphabet(value));

            Console.ReadKey();
        }
    }
}
