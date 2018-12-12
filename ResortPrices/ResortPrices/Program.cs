using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ResortPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 200, 200, 180, 180, 160, 160, 160, 145 };
            int input;
            int nightPrice = 1;
            int total;

            WriteLine("Please enter the number of nights you plan on staying.");
            input = Convert.ToInt32(ReadLine());

            if (input < 8)
            {
                nightPrice = arr[input];
            }
            else if (input >= 8)
            {
                nightPrice = arr[8];
            }

            total = input * nightPrice;

            WriteLine("You plan on staying {0} nights", input);
            WriteLine("Your total will be {0} at {1} a night", total.ToString("C"), nightPrice.ToString("C"));

        }
    }
}
