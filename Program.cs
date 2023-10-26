using System;

// A method is a block of code which only runs when it is called.

// You can pass data, known as parameters, into a method.

// Methods are used to perform certain actions, and they are also known as functions.

// Why use methods? To reuse code: define the code once, and use it many times.

namespace HelloWorld
{
    class Program
    {


        // methods
        static int addition(int a, int b) // this will be used when the function is called.
        {
            Console.WriteLine(" Line 19: Inside Addition Function");
            int sum = a + b;
            return sum;
        }

        static int subtraction(int a, int b)
        {
            int sub = a - b;
            return sub;
        }

        // Multiplication a*b



        //division a/b




        //Modulus a%b
        static void Main(string[] args) // Main function is the entry point of the application.
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Line 27: IN Main Function");
            int sub = subtraction(12, 10);
            Console.WriteLine($"The sub is {sub}");

            // sum = addition(10, 15);
            // Console.WriteLine($"The sum is {sum}");


        }
    }
}