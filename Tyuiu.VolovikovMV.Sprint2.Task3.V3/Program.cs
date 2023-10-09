using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolovikovMV.Sprint2.Task3.V3.Lib;

namespace Tyuiu.VolovikovMV.Sprint2.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Воловиков М. В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Воловиков Михаил Васильевич | АСОиУб-23-3                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Написать программу, которая вычисляет требуемое значение       *");
            Console.WriteLine("* функции Y с использованием вложенных оператор if-else, где пользователь *");
            Console.WriteLine("* вводит значение переменной X с клавиатуры.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение Х:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат: " + ds.Calculate(x));
            Console.ReadKey();

        }
    }
}
