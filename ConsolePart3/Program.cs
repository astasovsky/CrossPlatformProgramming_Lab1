using System;

namespace ConsolePart3
{
    class Program
    {
        /// <summary>
        /// Calling library method MyAtan(x,e) from MyLib.dll.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите число х: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите точность e: ");
            double e = double.Parse(Console.ReadLine());

            //Calling the method of calculation MyAtan(x,e) from library.
            double my_atan = MyLib.MyMethods.MyAtan(x, e);
            ///Calling the method from <see cref="Math"/>.
            double atan = Math.Atan(x);
            double calculation_error = 100 * Math.Abs(my_atan - atan) / atan;
            Console.WriteLine("\nСумма ряда = " + my_atan);
            Console.WriteLine("Точное значение = " + atan);
            Console.WriteLine($"Ошибка вычислений = {Math.Round(calculation_error,2)}%");
        }
    }
}
