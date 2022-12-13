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
            Console.WriteLine("Please enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[size];
            Console.WriteLine("reading input from user and storing into array");
            for (int i = 0; i < size; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Display array elements");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " ");
            }

        }
    }
}
