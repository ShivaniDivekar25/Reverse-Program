using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class ReverseProgram
    {
        public static void ReverseNumber(int number)
        {
            int temp = number;
            int remainder = 0, reverse = 0;
            while (number != 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
                Console.WriteLine("Reaminder:{0} number:{1} reverse:{2}", remainder, number, reverse);
            }
            //Console.WriteLine("Reverse number is:" + reverse);
            if (temp==reverse)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }
        }

        public static void ReverseWord(string word)
        {
            string reverse = string.Empty;
            char[] listOfChar = word.ToCharArray();
            for (int i = 0; i < listOfChar.Length; i++)
            {
                reverse = listOfChar[i] + reverse;
            }
            Console.WriteLine("Reverse = "+reverse);
            if (word == reverse)
            {
                Console.WriteLine("Word is palindrome");
            }
            else
            {
                Console.WriteLine("Word is not palindrome");
            }
        }
    }
}
