using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyankovaVV.Sprint3.Task5.V24.Lib;

namespace Tyuiu.PyankovaVV.Sprint3.Task5.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 12;

            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Пьянкова В. В. | АСОиУб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                    *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #24                                                              *");
            Console.WriteLine("* Выполнила: Пьянкова Виктория Вячеславовна | АСОиУб-23-2                  *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Вычислить сумму ряда при x = 2                                           *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine($"Старт шага первой суммы ряда = {startValue1}");
            Console.WriteLine($"Старт шага второй суммы ряда = {startValue2}");
            Console.WriteLine($"Конец шага первой суммы ряда = {stopValue1}");
            Console.WriteLine($"Конец шага второй суммы ряда = {stopValue2}");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine($"сумма ряда = {ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2)}");
            Console.ReadKey();
        }
    }
}
