using System;

namespace Homework
{
    class Program
    {
        static void Main()
        {
            /* 3 - new branch task*/
            Console.WriteLine(IsPrimal(3));
        }
        static bool IsPrimal(int number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number%i == 0)
                    {
                        return false;
                    }

                }
                return true;
            }
        }
       

    }   
}
