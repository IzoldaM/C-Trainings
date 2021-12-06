using System;
using System.Text.RegularExpressions;

namespace Homework1
{
    class Program
    {
        static void Main()
        {
            /*First Homework Task:
             1. Check if user entered string is a number
             2. Check if number is in range
             3. Convert number to Lithuanian text
            */


            /*Number in range between -19 and 19*/
            Console.WriteLine("Please enter a number between -19 and 19");
            string UserInput = Console.ReadLine();
            
            if (IsNumeric(UserInput) == true)
            {

                Console.WriteLine(ChangeNumberToText(Convert.ToInt32(UserInput)));
                
            }
            else
            {
                Console.WriteLine("Your entered input is invalid");
            }

            /*Number in range between -99 and 99*/
            Console.WriteLine("Please enter a number between -99 and 99");
            string UserInput2 = Console.ReadLine();

            if (IsNumeric(UserInput2) == true)
            {

                Console.WriteLine(ChangeNumberToText99(Convert.ToInt32(UserInput2)));

            }
            else
            {
                Console.WriteLine("Your entered input is invalid");
            }

        }

        /*IsNumeric function checks if string input is a number.
         Typically in-built function TryParce can be used.*/
        static bool IsNumeric(string InputString)
        {
            
            int counter = 0;
            if ((InputString[0] == '-' && InputString[1]!='0') || (InputString[0] == '0' && InputString.Length == 1) || Regex.IsMatch(Char.ToString(InputString[0]), @"[1-9]") == true)
            {
                counter++;
            }
            for (int i = 1; i < InputString.Length; i++)
            {
                if (Regex.IsMatch(Char.ToString(InputString[i]), @"\d") == true)
                {
                    counter++;
                }
            }
            if (counter == InputString.Length)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /*Function that checks if string is a number firstly then if yes, if it's in range*/
        static bool IsInRange (int InputNumber, int MinRangeValue = -19, int MaxRangeValue = 19)
        {
            if (InputNumber>= MinRangeValue && InputNumber <= MaxRangeValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*Function converts digit to text*/
        static string ConvertDigitToString(int i)
        {
            switch (i)
            {
                case 0: return "nulis"; break;
                case 1: return "vienas"; break;
                case 2: return "du"; break;
                case 3: return "trys"; break;
                case 4: return "keturi"; break;
                case 5: return "penki"; break;
                case 6: return "sesi"; break;
                case 7: return "septyni"; break;
                case 8: return "astuoni"; break;
                case 9: return "devyni"; break;
                default: return ""; break;
            }
        }

        /*Function converts teens to string*/
        static string ConvertTeensToString(int n)
        {
            switch (n)
            {
                case 10: return "desimt"; break;
                case 11: return "vienuolika";break;
                case 12: return "dvylika"; break;
                case 13: return "trylika"; break;
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19: return ConvertDigitToString(n - 10) + "olika"; break;
                default: return ""; break;
            }
        }


        static string ConvertTensToString(int t)
        {
            switch (t/10)
            {
                case 2: return "dvidesimt"; break;
                case 3: return "trisdesimt"; break;
                case 4: 
                case 5: 
                case 6: 
                case 7: 
                case 8:
                case 9: return ConvertDigitToString(t/10) + "asdesimt"; break;
                default: return ""; break;
            }
        }

        /*Function converts number (in range between -19 and 19) to Lithunian text*/
        static string ChangeNumberToText(int Number)
        {
            if (IsInRange(Number) == false)
            {
                return "Number is out of range";
            }
            else if (Number < 0)
            {
                if(Number*-1 < 10)
                {
                    return "minus " + ConvertDigitToString(Number*-1);
                }
                else
                {
                    return "minus " + ConvertTeensToString(Number*-1);
                }
            }
            else
            {
                if (Number < 10)
                {
                    return ConvertDigitToString(Number);
                }
                else
                {
                    return ConvertTeensToString(Number);
                }
            }
        }

        static string ChangeNumberToText99(int Number)
        {
            if (IsInRange(Number, -99, 99) == false)
            {
                return "Number is out of range";
            }
            else if (Number < 0)
            {
                if (Number * -1 < 10)
                {
                    return "minus " + ConvertDigitToString(Number * -1);
                }
                else if (Number*-1 < 20)
                {
                    return "minus " + ConvertTeensToString(Number * -1);
                }
                else if (Number*-1 % 10 == 0)
                {
                    return "minus " + ConvertTensToString(Number * -1);
                }
                else
                {
                    int HelpNumber = Number * -1;
                    return "minus " + ConvertTensToString(HelpNumber) +" "+ ConvertDigitToString(HelpNumber - (HelpNumber/10)*10);
                }
            }
            else
            {
                if (Number < 10)
                {
                    return ConvertDigitToString(Number);
                }
                else if (Number < 20)
                {
                    return  ConvertTeensToString(Number);
                }
                else if (Number % 10 == 0)
                {
                    return ConvertTensToString(Number);
                }
                else
                {
                    return ConvertTensToString(Number) + " " + ConvertDigitToString(Number - (Number / 10) * 10);
                }
            }
        }


    }
}
