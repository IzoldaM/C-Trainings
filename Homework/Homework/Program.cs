using System;

namespace Homework
{
    class Program
    {
        static void Main()
        {
            /*1 - Git commit test task*/
            Console.WriteLine(Max_function(10, 5, 3));
            /*2 - Git commit test task*/
            Console.WriteLine(InRange(10, 5, 3));

        }
        static int Max_function (int a, int b, int c)
        {
            int largest_num;
            if (a > b)
            {
                if (a > c)
                {
                    largest_num = a;
                }
                else
                {
                    largest_num = c;
                }
            }
            else if (b > c)
            {
                largest_num = b;
            }
            else
            {
                largest_num = c;
            }
            return largest_num;
        }

        static bool InRange (int test_number, int min_val, int max_val)
        {
            bool result;
            if (test_number >= min_val && test_number <= max_val)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
