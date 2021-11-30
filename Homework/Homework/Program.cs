using System;

namespace Homework
{
    class Program
    {
        static void Main()
        {
            /* 3 - new branch task*/
            Console.WriteLine(IsPrimal(3));
            /* 4 - new branch task*/
            Console.WriteLine(D20());
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

        static int D20()
        {
            Random rnd = new Random();
            return Random.Next(1,21);
           
        }       

    }   
}
