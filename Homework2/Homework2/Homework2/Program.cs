using System;

namespace Homework2
{
    class Program
    {
        static void Main()
        {
            //Program generates six digits random number, checks if all digits are unique
            //If all digits are unique, then checks if each multiplication (by 2,3,4,5,6) returns wanted result
            Random rnd = new Random();
            bool output = false;
            
            while (output != true)
            {

                int MagicNumber = rnd.Next(100000,1000000);
                int MagicNumberM2 = MagicNumber * 2;
                int MagicNumberM3 = MagicNumber * 3;
                int MagicNumberM4 = MagicNumber * 4;
                int MagicNumberM5 = MagicNumber * 5;
                int MagicNumberM6 = MagicNumber * 6;


                if (checkIfAllArrayElementsAreDifferent(intNumberToArray(MagicNumber)) == false)
                {
                    output = false;
                }
                else if(checkIfAllArrayElementsAreDifferent(intNumberToArray(MagicNumberM2)) == false || checkIfArrayEmementsAreEqualButDifferentlySorted(intNumberToArray(MagicNumber), intNumberToArray(MagicNumberM2)) == false)
                {
                    output = false;
                }
                else if (checkIfAllArrayElementsAreDifferent(intNumberToArray(MagicNumberM3)) == false || checkIfArrayEmementsAreEqualButDifferentlySorted(intNumberToArray(MagicNumber), intNumberToArray(MagicNumberM3)) == false)
                {
                    output = false;
                }
                else if (checkIfAllArrayElementsAreDifferent(intNumberToArray(MagicNumberM4)) == false || checkIfArrayEmementsAreEqualButDifferentlySorted(intNumberToArray(MagicNumber), intNumberToArray(MagicNumberM4)) == false)
                {
                    output = false;
                }
                else if (checkIfAllArrayElementsAreDifferent(intNumberToArray(MagicNumberM5)) == false || checkIfArrayEmementsAreEqualButDifferentlySorted(intNumberToArray(MagicNumber), intNumberToArray(MagicNumberM5)) == false)
                {
                    output = false;
                }
                else if (checkIfAllArrayElementsAreDifferent(intNumberToArray(MagicNumberM6)) == false || checkIfArrayEmementsAreEqualButDifferentlySorted(intNumberToArray(MagicNumber), intNumberToArray(MagicNumberM6)) == false)
                {
                    output = false;
                }
                else
                {
                    output = true;
                    Console.WriteLine($"Magic number is {MagicNumber}");
                }

            }
            
        }

        static int[] intNumberToArray(int input)
        {
            String numberToString = input.ToString();
            int[] numbersArray = new int[numberToString.ToString().Length];
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = Convert.ToInt32(numberToString[i]);
            }
            return numbersArray;
        }

        static bool checkIfAllArrayElementsAreDifferent(int[] input)
        {
            Array.Sort(input);
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                    return false;
            }
            return true;
        }

        static bool checkIfArrayEmementsAreEqualButDifferentlySorted(int[] baseArray, int[] compareToArray)
        {

            if (baseArray.Length != compareToArray.Length)
            {
                return false;
            }
            else
            {
                int checkSum = 0; 

                for (int i = 0; i < baseArray.Length; i++)
                {
                    for (int j = 0; j < compareToArray.Length; j++)
                    {
                        if (baseArray[i] == compareToArray[j] && i!=j)
                        {
                            checkSum += 1;
                        }
                    }
                }

                if (checkSum == baseArray.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
                
        }

    }
}
