using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int [8];
            int input;
            int i;


            for (i = 0; i < 8; i++)
            {
                WriteLine("Please enter a value for {0}", i);
                arr[i] = Convert.ToInt32(ReadLine());
            }

            WriteLine("Type 30 to exit");

            do
            {
                WriteLine("Type 10 to view in ascending order, 20 to view in descending order, or a 0-7 to view a specific position");
                input = Convert.ToInt32(ReadLine());

                if (input >= 0 && input < 8)
                {
                    WriteLine("The value is {0}", input);
                }
                else if (input == 10)
                {
                    for (i = 0; i < 8; ++i)
                    {
                        WriteLine("" + arr[i]);
                    }
                }
                else if (input == 20)
                {
                    for (i = 7; i >= 0; --i)
                    {
                        WriteLine("" + arr[i]);
                    }
                }
                else
                {
                    WriteLine("Invalid input");
                }
            } while (input != 30);
        }
    }
}
