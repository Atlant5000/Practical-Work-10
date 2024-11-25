using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Input();
        }
        /// <summary>
        /// Метод вывода
        /// </summary>
        public static void Input()
        {
            Console.WriteLine($"x={Math.Round(Func(5, 7) + Func(12, 8) + Func(19, 2))}");
            Console.Read();
        }
        /// <summary>
        /// Метод функции
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Func(int a, int b)
        {
            return (Math.Sqrt(a) + a / Math.Sqrt(b) + b);
        }
    }
}
