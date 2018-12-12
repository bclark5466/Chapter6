using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 52802, 52803, 52804, 52805, 52806, 52807, 52808, 52809, 52810, 52811 };
            int input;
            int i;

            do
            {
                bool validZip = false;
                WriteLine("Please enter a zip code");
                input = Convert.ToInt32(ReadLine());
                for (i = 0; i < arr.Length; i++)
                {
                    if (input == arr[i])
                    {
                        validZip = true;
                    }
                }
                if (validZip)
                {
                    WriteLine("Zip code {0} is within our jurisdiction", input);
                }
                else
                {
                    WriteLine("I'm sorry, that zip code is outside of our boundaries");
                }
                
                

            } while (input != 90);
        }
    }
}
