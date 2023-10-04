using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolovikovMV.Sprint2.Task1.V5.Lib;

namespace Tyuiu.VolovikovMV.Sprint2.Task1.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 154, b = 163, c = 134, d = 137;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a,b,c,d);
            Console.Title = "Спринт #2 | Выполнил: Воловиков М. В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Воловиков Михаил Васильевич | АСОиУб-23-3                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Написать программу из операций сравнений                       *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность можно чередовать, но          *");
            Console.WriteLine("* использовать один раз в выражении) и логических операций                *");
            Console.WriteLine("* (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), *");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую             *");
            Console.WriteLine("* последовательность(массив): (True, False, False, False, True, False)    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a = 154, b = 163, c = 134, d = 137                                      *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
