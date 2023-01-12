using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTask
{
    internal class ArrayTasks
    {
        internal int[] EnterArray()
        {
            Console.Write("Masssivin uzunlugunu daxil edin: ");
            int x = int.Parse(Console.ReadLine());
            int[] mass = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.Write($"mass{i}=");
                mass[i] = int.Parse(Console.ReadLine());
            }
            return mass;

        }
        internal int[] FindNumbers(int[] numbers)
        {
            int newarraylength = 0, index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                double b = Math.Sqrt(numbers[i]);
                if (b % 1 == 0)
                {
                    newarraylength++;
                }

            }

            int[] newarray = new int[newarraylength];

            for (int i = 0; i < numbers.Length; i++)
            {
                double b = Math.Sqrt(numbers[i]);
                if (b % 1 == 0)
                {
                    newarray[index] = numbers[i];
                    index++;
                }

            }
            return newarray;
        }
        internal void Print(int[] massiv)
        {
            foreach (var item in massiv)
            {
                Console.Write($"{item,3}");
            }
            Console.WriteLine();
        }

    }
    internal class NumberTasks
    {
        internal int EnterNumber()
        {
            Console.Write("Ededi daxil edin :");
            int entnumber = int.Parse(Console.ReadLine());
            return entnumber;
        }

        internal int ReserveNumber(int number)
        {
            int reverseNumber = 0, a;
            for (int i = (int)Math.Log10(number); i >= 0; i--)
            {
                a = number % 10;
                number = number / 10;
                reverseNumber += a * (int)Math.Pow(10, i);
            }
            return reverseNumber;
        }

        internal void Print(int number)
        {
            Console.WriteLine(number);
        }
    }
}
