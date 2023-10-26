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
        static int Multiplication(int a, int b)
        {
            int mult = a * b;
            return mult;
        }


        //division a/b

        static int Division(int a, int b)
        {
            // int div = a / b;
            return a / b;
        }




        //Modulus a%b
        static int Modulus(int a, int b)
        {
            return a % b;
        }


        static void displayMessage(string message)
        {
            Console.WriteLine($"{message}");
        }

        // factorial 

        // int number;

        static int getFactorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }


        static void Main(string[] args) // Main function is the entry point of the application.
        {
            Console.WriteLine("Hello World!");

            displayMessage("Line 27: IN Main Function");
            int add = addition(12, 10);
            displayMessage($"The add is {add}");
            int sub = subtraction(12, 10);
            displayMessage($"The sub is {sub}");
            int mult = Multiplication(12, 10);
            displayMessage($"The multiplication is {mult}");
            int div = Division(20, 10);
            displayMessage($"The division is {div}");
            int mod = Modulus(12, 10);
            displayMessage($"The Modulus is {mod}");

            displayMessage("Factoiral of a Number");
            displayMessage("Enter a number to get the factorial!");
            int number = int.Parse(Console.ReadLine());

            int factorial = getFactorial(number);
            displayMessage($"Factorial of {number} is {factorial}");

            factorial = getFactorial(6);
            displayMessage($"Factorial of 6 is {factorial}");


            // Write a method that takes an array of integers and
            //  returns the sum of all elements in the array.

            int[] array = { 1, 2, 3, 4, 5 }; // 15
            int sum = sumOfArray(array);
            displayMessage($"Sum of array is {sum}");
        }

        // array from the user
        // return sum

        static int sumOfArray(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum = sum + element;
            }
            return sum;
        }
    }
}