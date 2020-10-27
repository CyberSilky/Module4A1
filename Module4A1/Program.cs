using System;
using static System.Console;

namespace Module4A
{
    class Program
    {
        static void Main(string[] args)
        {
            int userValue1, userValue2;

            WriteLine("Please enter an integer: ");
            userValue1 = int.Parse(ReadLine());

            WriteLine("Please enter another integer: ");
            userValue2 = int.Parse(ReadLine());

            //print the values before being passed to the method
            WriteLine($"First initial value is {userValue1} and second value is {userValue2}");

            int multiplied = 0;
            int mainSum = Addition(userValue1, userValue2, out multiplied);

            WriteLine($"After method call the first initial value {userValue1} and second value is {userValue2}");

            WriteLine($"The answer of the addition is {mainSum} and the answer to the multiplication is {multiplied}");

            string fullName = Addition("Bob", "Smith");
            WriteLine($"Call to addition with strings results in {fullName}");

        }
        
        //out and ref are pretty much the same but using out explicitely says I am going to return something to you so pass something in and I will change it for you
        static int Addition(int number1, int number2, out int multiples)
        {
            number1 = number1 * 2;
            number2 = number2 * 2;

            WriteLine($"The first paramameter's value in the method is {number1} and the second is {number2}");
            int sum = number1 + number2;
            multiples = number1 * number2;

            return sum;
        }

        static string Addition(string name1, string name2)
        {
            string finalName = name1 + ' ' + name2;
            return finalName;
        }
    }
}
