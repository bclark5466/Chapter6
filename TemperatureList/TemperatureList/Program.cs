using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            int average;

            for (int i = 0; i < 7; i++)
            {
                WriteLine("Please enter a value for day {0}", (i + 1));
                arr[i] = Convert.ToInt32(ReadLine());
            }

            average = (arr.Sum() / 7);

            for (int i = 0; i < 7; ++i)
            {
                WriteLine("The temperature on this day was {0} degrees, {1} degrees away from average", arr[i], Math.Abs(arr[i] - average));
            }
        }
    }
}
