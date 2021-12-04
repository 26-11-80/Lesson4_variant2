using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_variant2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            double N = Convert.ToDouble(Console.ReadLine());
            for (double i = 1; i <= N; i++)
                Console.WriteLine(i + ": " + (2 * i - 1));
            Console.WriteLine("Квадрат числа N равен сумме данных чисел");
            Console.ReadKey(true);
        }
    }
}
