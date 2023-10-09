using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolovikovMV.Sprint2.Task4.V11.Lib;

namespace Tyuiu.VolovikovMV.Sprint2.Task4.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Воловиков М. В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Воловиков Михаил Васильевич | АСОиУб-23-3                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Написать программу, которая вычисляет требуемое значение       *");
            Console.WriteLine("* с использованием тернарного оператора, где пользователь                 *");
            Console.WriteLine("* вводит значение переменной X, Y с клавиатуры.                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение Х:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат: " + ds.Calculate(x,y));
            Console.ReadKey();

        }
    }
}
