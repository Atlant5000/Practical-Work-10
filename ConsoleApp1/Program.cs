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
            Value();
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static double Func(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }
        static void Value()
        {
            int number1 = Input("a=");
            int number2 = Input("b=");
            Console.WriteLine($"Наибольшее число = {Func(number1, number2)}");
            Console.ReadLine();
        }
    }
}
