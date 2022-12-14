using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Palindrome1
    {
        public static void ReverseNumber(int number)
        {
            int temp = number;      //To store the variable
            int remainder = 0, reverse = 0;     //Initialize the value to 0
            while (number != 0)     //using while loop to check the condition
            {
                remainder = number % 10;        //To get remainder
                reverse = (reverse * 10) + remainder;       //To get reverse value
                number = number / 10;       //To seperate the number
                Console.WriteLine("Reaminder:{0} number:{1} reverse:{2}", remainder, number, reverse);      //Print the all values
            }
            
            if (temp == reverse)        //If condition to check the number is palindrome or not.
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
            string reverse = string.Empty;      //To store the value. 
            char[] listOfChar = word.ToCharArray();     //Use array.
            for (int i = 0; i < listOfChar.Length; i++)     //Use for loop to get reverse word.
            {
                reverse = listOfChar[i] + reverse;
            }
            Console.WriteLine("Reverse = " + reverse);    //Printing reverse value
            if (word == reverse)    //If condition to check Word is palindrome or not.
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
