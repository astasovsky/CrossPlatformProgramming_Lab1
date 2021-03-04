using System;

namespace MyLib
{
    /// <summary>
    /// Methods that implement the task.
    /// </summary>
    public class MyMethods
    {
        /// <summary>
        /// Calculating the area of the ring.
        /// </summary>
        /// <param name="outer_radius">Radius of the outer circle.</param>
        /// <param name="inner_radius">Radius of the inner circle.</param>
        /// <returns>Returns area of the ring.</returns>
        public static double RingArea(double outer_radius, double inner_radius)
        {
            return Math.PI * (outer_radius * outer_radius - inner_radius * inner_radius);
        }


        /// <summary>
        /// Finding the sum of n members of series.
        /// </summary>
        /// <param name="x">Real number x.</param>
        /// <param name="n">Number of series members.</param>
        /// <returns>Sum.</returns>
        public static double SeriesSum(double x, int n)
        {
            double S = 0;
            for (int i = 0; i <= n; i++)
            {
                S += ((i % 2) == 0 ? 1 : -1) * Math.Pow(x, 2 * i + 1) / (2 * i + 1);
            }
            return S;
        }


        /// <summary>
        /// Atan(x).
        /// </summary>
        /// <param name="x">Real number x.</param>
        /// <param name="e">Accuracy.</param>
        /// <returns>Returns angle for a given tg.</returns>
        public static double MyAtan(double x, double e)
        {
            double S = 0, an;
            int n = 0;
            do
            {
                an = ((n % 2) == 0 ? 1 : -1) * Math.Pow(x, 2 * n + 1) / (2 * n + 1);
                S += an;
                n++;
            } while (Math.Abs(an) > e);
            return S;
        }
    }
}
