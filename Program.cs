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




        // factorial 

        // int number;



        //1. method that takes an array of integers and returns the largest number in the array
        // return type int
        // an array
        static int largestNumber(int[] array)
        {
            int max = int.MinValue; //(- Infinity)

            foreach (int element in array)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        // 2. method to print the fibonacci series.
        // return type: void ()
        // int n - the limit of the fibonacci series.

        static void displayMessage(string message)
        {
            Console.WriteLine($"{message}");
        }
        static void printFibonacci(int n)
        {
            int first = 0, second = 1;
            displayMessage("Fibonacci Series");
            for (int i = 0; i <= n; i++)
            {
                Console.Write(first);
                int next = first + second;
                first = second;
                second = next;
            }
            displayMessage(""); //move to the next line.
        }

        // 3. method that accepts a number as input and prints
        // the multiplication table for that number up to a specified range. 
        // return type: void()
        // user: number, range
        static void printMultiplicationTable(int number, int range)
        {
            for (int i = 1; i <= range; i++)
            {
                displayMessage($"{i} * {number} = {i * number}");
            }
        }

        // 4. method that takes an array of integers and 
        // returns the average (mean) of the numbers in the array. 
        // return type: double
        // user: array[] integers

        static double getArrayAverage(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum = sum + element;
            }
            return (sum / array.Length);
        }

        // 5.  method that takes a string and counts the number of 
        // vowels (A, E, I, O, U) in the string and returns the count.
        // return type: int
        // user: string
        static int countVowels(string str)
        {
            str = str.ToLower();
            int count = 0;
            // hello - string
            // ['h', 'e', 'l', 'l', 'o']
            // Method 1
            foreach (char ch in str)
            {
                if ("aeiou".Contains(ch))
                {
                    count++;
                }
            }
            // Method 2
            // for (int i = 0; i < str.Length; i++)
            // {
            //     if ("aeiou".Contains(str[i]))
            //     {
            //         count++;
            //     }
            // }
            return count;
        }

        // 6. method that checks if a number is a strong number (the sum of factorials of its
        // digits is equal to the number itself) and returns a boolean value.
        // return type: bool
        // user input: int
        // 145 => 1! + 4! + 5! => 1 + 24 + 125 => 145 

        static int getFactorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        static bool checkStrongNumber(int number)
        {
            int copy = number;
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10; // extract the last digit.
                sum = sum + getFactorial(digit); // add the factorial to the sum.
                number = number / 10; // remove the last digit.
            }

            // if (copy != sum)
            // {
            //     return false;
            // }
            // return true;
            // return copy == sum ? true : false;
            return copy == sum; // true other false
        }

        //7. method that takes a string and checks if it's a pangram
        // (contains all letters of the alphabet at least once,
        // see the explanation below) and returns a boolean value.  
        // return type: bool
        // user: string
        static bool checkPangram(string str)
        {
            str = str.ToLower();
            foreach (char ch in "acbdefghijklmnopqrstuvwxyz")
            {
                if (!str.Contains(ch))
                {
                    return false;
                }
            }
            return true;
        }

        //8.  method that takes a number as input and checks if it's a happy number (a number that eventually reaches 1 when
        // replaced by the sum of the square of each digit) and returns a boolean value. 
        // sum of squares of the number
        // return type: int
        // user : int number
        static int getSumOfSquares(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum = sum + (digit * digit);
                number = number / 10;
            }
            return sum;
        }

        // code happy number
        // return type: bool
        // user : int number
        static bool checkHappyNumber(int number)
        {
            // 19
            int sum = number;
            int cycleDetection = number;
            while (sum != 1 && cycleDetection != 4)
            {
                sum = getSumOfSquares(sum);

                cycleDetection = getSumOfSquares(getSumOfSquares(cycleDetection));
                // 19
                // sum =  1 + 81 = 82;
                // get square -> 82
                // get square -> 82 => 64 + 4=> 68

                // sum -> 82 => 68
                // get square -> 68 -> 36 + 64 -> 100
                // get square -> 100 -> 1 + 0 + 0 -> 1

                // sum -> 68 => 36 + 64 => 100
                // get square -> 1 -> 1
                // get square -> 1-> 1

                // sum -> 100 => 1 + 0 + 0 => 1
                // get square -> 1 -> 1
                // get square -> 1 -> 1

            }

            return sum == 1;
        }

        // 9. method that accepts a list (array) of integers and 
        // returns a new list (array) containing only the even numbers from the original list (array).
        // return type: int[] array
        // user input: int[] array

        static int[] filterEvenNumbers(int[] array)
        {
            int evenNoCount = 0;
            foreach (int element in array)
            {
                if (element % 2 == 0)
                {
                    evenNoCount++;
                }
            }

            int[] evenElements = new int[evenNoCount];
            int index = 0;
            foreach (int element in array)
            {
                if (element % 2 == 0)
                {
                    evenElements[index] = element;
                    index++;
                }
            }
            return evenElements;
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

