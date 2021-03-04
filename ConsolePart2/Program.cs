using System;

namespace ConsolePart2
{
    class Program
    {
        /// <summary>
        /// Calling library method SeriesSum(x,n) from MyLib.dll.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите число х: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите количество членов ряда n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nСумма членов ряда = " + MyLib.MyMethods.SeriesSum(x, n));
        }
    }
}
