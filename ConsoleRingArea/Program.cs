using System;

namespace ConsolePart1
{
    class Program
    {
        /// <summary>
        /// Calling library method RingArea(outer_radius,inner_radius) from MyLib.dll.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите внешний радиус кольца: ");
            double outer = double.Parse(Console.ReadLine());
            Console.Write("Введите внутренний радиус кольца: ");
            double inner = double.Parse(Console.ReadLine());
            Console.WriteLine("\nПлощадь кольца = " + MyLib.MyMethods.RingArea(outer, inner));
        }
    }
}
