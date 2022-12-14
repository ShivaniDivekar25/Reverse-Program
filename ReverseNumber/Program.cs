using ReverseNumber;

namespace Reversestore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");
            Console.WriteLine("Please choose any one program from below options.");
            Console.WriteLine("1:ReverseProgram\n2:Array\n3:Car\n4:Palindrome1");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //Code of block
                    Console.WriteLine("Please enter number");
                    int number = Convert.ToInt32(Console.ReadLine());
                    ReverseProgram.ReverseNumber(number);
                    Console.ReadLine();

                    Console.WriteLine("Please enter the word");
                    string word = Console.ReadLine();
                    ReverseProgram.ReverseWord(word);
                    Console.ReadLine();
                    break;
                case 2:
                    //Code of block
                    Array1.TestArray();
                    Console.ReadLine();
                    break;
                case 3:
                    //Code of block
                    Car myObj = new Car();
                    Console.WriteLine(myObj.model);
                    break;
                case 4:
                    //Code of block
                    Console.WriteLine("Please enter number");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Palindrome1.ReverseNumber(number1);
                    Console.ReadLine();

                    Palindrome1.ReverseNumber(number1);
                    Console.ReadLine();

                    Console.WriteLine("Please enter the word");
                    string word1 = Console.ReadLine();
                    Palindrome1.ReverseWord(word1);
                    Console.ReadLine();

                    Palindrome1.ReverseWord("nayan");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please choose number within given options");
                    break;
            }
            Console.ReadLine();

            //Console.WriteLine("Please enter number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //ReverseProgram.ReverseNumber(number);
            //Console.ReadLine();

            //Palindrome1.ReverseNumber(number);
            //Console.ReadLine();

            //Console.WriteLine("Please enter the word");
            //string word = Console.ReadLine();
            //ReverseProgram.ReverseWord(word);
            //Console.ReadLine();

            //Palindrome1.ReverseWord("nitin");
            //Console.ReadLine();

            //Array1.TestArray();
            //Console.ReadLine();

            //Car myObj = new Car();
            //Console.WriteLine(myObj.model);
        }
    }
}