using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Array1
    {
        public static void TestArray()
        {
            Console.WriteLine("Please enter size of array");    //User input.
            int size = Convert.ToInt32(Console.ReadLine());     //Convert user input to int.
            int[] number = new int[size];       //Creating array for number.
            Console.WriteLine("reading input from user and storing into array");
            for (int i = 0; i < size; i++)      //Using for loop to take array element.
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Display array elements");        //Printing array elements.
            for (int i = 0; i < number.Length; i++)     //Using for loop to store in Array.
            {
                Console.Write(number[i] + " ");
            }

        }
    }
}
