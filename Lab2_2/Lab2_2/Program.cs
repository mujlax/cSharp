using System;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Principal;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: Интервал начало");
            double intStart = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число: Интервал конец");
            double intEnd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число: Шаг");
            double intStep = Convert.ToDouble(Console.ReadLine());

           
            double x;

            int g = 0;

            const int M = 255;

            double [] msv = new double[M];

            Console.WriteLine("");
            Console.WriteLine("Изначальный массив");

            for (x = intStart; x < intEnd; x = x + intStep, g++)
                {
                if ((x > -3) && (x < -1))
                    msv[g] = Math.Pow(2, x + 2);

                if ((x >= -1) && (x <= 1))
                    msv[g] = Math.Atan(0.3 * x);

                if ((x > 1) || (x <= -3))
                    msv[g] = 2 * Math.Abs(1 / x) - 1;
                }

            for (int i = 0; i < g; i++)
            {
                Console.WriteLine(msv[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Max: " + msv.Max());

            for (int i = 0; i < g - 1; i++)
            {
                //поиск минимального числа
                int min = i;
                for (int j = i + 1; j < g; j++)
                {
                    if (msv[j] < msv[min])
                    {
                        min = j;
                    }
                }
                //обмен элементов
                double temp = msv[min];
                msv[min] = msv[i];
                msv[i] = temp;

                
            }

            Console.WriteLine("");
            Console.WriteLine("Сортировка методом выбора");
            for (int i = 0; i < g; i++)
            {
                Console.WriteLine(msv[i]);
            }
        }

    }
}
