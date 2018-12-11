using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Scores_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            const int MAX = 100, MIN = 0;
            int i;
            int[] arr = new int[4];

            for (i = 0; i < 4; i++)
            {
                WriteLine("Please enter test score {0}", (i + 1));
                input = Convert.ToInt32(ReadLine());
                if (input >= MIN && input <= MAX)
                {
                    arr[i] = input;
                }
                else
                {
                    WriteLine("You moron");
                    i--;
                }
            }

            if (arr[0] <= arr[1] && arr[1] <= arr[2] && arr[2] <= arr[3])
            {
                WriteLine("Good job, you kept improving");
                for (i = 0; i < 4; i++)
                {
                    WriteLine("Score {0} was {1}", (i + 1), (arr[i]));
                }
            }
            else if (arr[0] >= arr[1] && arr[1] >= arr[2] && arr[2] >= arr[3])
            {
                WriteLine("Bro, you suck. You never improved");
                for (i = 0; i < 4; i++)
                {
                    WriteLine("Score {0} was {1}", (i + 1), (arr[i]));
                }
                WriteLine("Just to make you feel better, we'll put them in reverse");
                for (i = 3; i >= 0; i--)
                {
                    WriteLine("Score {0} was {1}", (i + 1), (arr[i]));
                }

            }
            else
            {
                WriteLine("What were you even doing, you were all over the place");
                for (i = 0; i < 4; i++)
                {
                    WriteLine("Score {0} was {1}", (i + 1), (arr[i]));
                }
            }
        }
    }
}
