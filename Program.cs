using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { 
                { 3, 4, 5, 7 }, 
                { 4, 5, 6, 7 }, 
                { 4, 7, 9, 2 } };
            int sumLine = 0;
            int sumColumn = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                sumLine += array[1, i];
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumColumn += array[i, 0];
            }
            Console.WriteLine($"Сумма второй строки: {sumLine}\nСумма первого столбца: {sumColumn}");
        }
    }
}
