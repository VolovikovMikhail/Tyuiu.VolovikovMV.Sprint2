using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolovikovMV.Sprint2.Task6.V7.Lib;

namespace Tyuiu.VolovikovMV.Sprint2.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Воловиков М. В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Воловиков Михаил Васильевич | АСОиУб-23-3                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: С начала 1990 года по некоторый день прошло n месяцев и 2 дня. *");
            Console.WriteLine("* Определить название месяца (январь, февраль и т. п.) этого дня.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите год:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сколько месяцев прошло:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат: " + ds.FindMonthName(g, m));
            Console.ReadKey();
        }
    }
}
