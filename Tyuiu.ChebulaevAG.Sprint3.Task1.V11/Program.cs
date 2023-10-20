using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChebulaevAG.Sprint3.Task1.V11.Lib;

namespace Tyuiu.ChebulaevAG.Sprint3.Task1.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Чебулаев А. Г. | РПСб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Чебулаев Андрей Геннадьевич | РПСб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
            Console.WriteLine("* ряда по формуле, при a=0,75                                             *");
            Console.WriteLine("* p = prod k = 1 to 14 (a ^ k + 1/2).                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double value = 0.75;
            int startValue = 1;
            int stopValue = 14;

            Console.WriteLine("Перемещенная a = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение рада = " + ds.GetMultiplySeries(value, startValue, stopValue));

            Console.ReadKey();
        }
    }
}
