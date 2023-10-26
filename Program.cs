using System;
using System.Reflection.Metadata;

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

            displayMessage("IS Prime Check");
            bool result = IsPrime(8);
            displayMessage($"{result}");

            displayMessage("Calculate the area of the rectangle");
            double area = calculateRectangle(12.2, 23.2);
            int ar = calculateRectangle(10, 10);

            int defaultArea = calculateRectangle();
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

        // Question 4: Create a method that checks if a given number 
        // is prime and returns a boolean value.
        // Prime number is a number which is only divisible by 1 and itself.
        // 5,7,11,13,17,19... are examples.

        // int number 
        // return type: bool

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i < number; i++)
            { // between 2 and number-1
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // Question 5: Write a method that takes a string as input and
        // returns its length (int) (number of characters). 
        static int getStringLength(string str)
        {
            // int length = str.Length;
            // return length;
            return str.Length;
        }
        // Question 6: Create a method that reverses a given string and
        // returns the reversed string.

        static string reverseString(string str)
        {
            char[] ch = str.ToCharArray(); // convert the string to array of characters
            Array.Reverse(ch); // we use inbuilt function to reverse the array
            return new string(ch); // we create a new string and pass the character array
        }

        // Question 7: Write a method that takes a temperature in Celsius and
        // converts it to Fahrenheit using the formula: F = C * 9 / 5 + 32.

        static double CelsiusToFarenhiet(double celcius)
        {
            return ((celcius * 9) / 5) + 32;
        }


        // Question 8: Create a method that takes a positive integer and
        // checks (Boolean) if it's a palindrome (reads the same forwards and backwards).

        static bool checkPalindrome(int number)
        {
            if (number < 1)
            {
                return false;
            }
            int copy = number;
            int reverse = 0;
            while (number > 0)
            {
                int digit = number % 10; // extract the last digit.
                reverse = (reverse * 10) + digit; // *10 to change unit position and add the digit.
                number = number / 10; // remove the last the digit.
            }
            if (copy == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Question 10: Create a method that calculates the area of a rectangle and
        // returns it based on its length and width.

        static double calculateRectangle(double length, double width)
        {
            return length * width;
        }

        static int calculateRectangle(int length, int width)
        {
            return length * width;
        }

        static int calculateRectangle()
        {
            return 10 * 10;
        }
    }
}


// With Method Overloading, multiple methods can have the same name with different parameters:
/**
int MyMethod(int x)
float MyMethod(float x)
double MyMethod(double x, double y)
*/











// Question 9: Write a method that takes two strings and checks if they are anagrams (contain the same letters in different orders).

