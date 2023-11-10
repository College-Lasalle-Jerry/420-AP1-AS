// 1. Write a method to find and return the second largest element in an integer array. 
// Provide the method and an example. 

// Ex - [10, 13, -1, 2, 6, 7] => 10 is the second largest element 

// static int getSecondLargestNumber(int[] array)
// {

//     // run the loop once. 
//     // we take 2 variables
//     // firstLargest
//     // SecondLargest
//     int firstLargest = int.MinValue;
//     int SecondLargest = int.MinValue;
//     // foreach loop
//     foreach (int element in array)
//     {
//         if (element > firstLargest)
//         {
//             SecondLargest = firstLargest;
//             firstLargest = element;
//         }
//         else if (element > SecondLargest && element != firstLargest)
//         {
//             SecondLargest = element;
//         }
//     }
//     return SecondLargest;
// }

// // 2. Create a method that checks if a string contains only unique characters (no duplicates).  
// // Ex – Hello -> duplicates present,
// // Ex – bye -> no duplicates present 

// // return type: bool
// // input: string

// static bool checkDuplicates(string str)
// {
//     // check duplicates
//     for (int i = 0; i < str.Length; i++)
//     {
//         for (int j = 1; j < str.Length; j++)
//         {
//             if (str[i] == str[j])
//             {
//                 //hello
//                 // h e, h l, h l, h 0
//                 // e l, e l, e 0
//                 // l l, => false
//                 return false;
//             }
//         }
//     }
//     return true;
// }

// // find a better solution. (HW)

// // 3. Write a method that calculates the sum of the squares of the first n natural numbers.  
// // Ex – 10, 1+2+3+4+5+6+7+8+9+10 => 55 

// // return : int
// // input: int

// static int getSumOfNaturalNumber(int n)
// {
//     int sum = 0;
//     for (int i = 1; i <= n; i++)
//     {
//         //sum = sum + n;
//         sum += n;
//     }
//     return sum;
// }

// // 4. Write a method that calculates the power of a number (x^n) without using the built-in Math.Pow function. (Use For /while Loop)
// // Ex – x = 2, n = 2 => 2^2  => 4  

// // return : int number, int power
// // input: int

// static int getPower(int number, int power)
// {
//     // if the number is negative;
//     // -2^2 => -2 * -2 => 4
//     // -2^3 => -2 * -2 * -2 =>-8
//     if (number < 0)
//     {
//         power = 1 / power;
//         number = -number;
//     }
//     int result = 1;
//     for (int i = 1; i <= power; i++)
//     {
//         result = result * number;
//     }
//     return result;
// }

// //5. GCD
// // Greatest Common Denominator
// // return as int
// // input : int a, int b

// static int calculateGCD(int a, int b)
// {
//     // a/b, 3/0 => Infinity, 0/1 => undefined.
//     while (b != 0)
//     {
//         int temp = b;
//         b = a % b;
//         a = temp;

//         // 10/5
//         // temp = 5
//         // b = 10%5 => 0
//         // a = 5
//     }
//     return a;
// }


// // Time Complexity
// // 1. 

// Random rnd = new Random();
// int a = 0, b = 0;
// int N = 10, M = 10;
// for (int i = 0; i < N; i++)
// {
//     a = a + rnd.Next();
// }
// // 0 to N => O(N)
// for (int j = 0; j < M; j++)
// {
//     b = b + rnd.Next();
// }
// // 0 to M => O(M)


// // time complexity => O(N+M) => O(N)


// //2. 
// a = 0;
// for (int i = 0; i < N; i++)
// {
//     for (int j = N; j > i; j--)
//     {
//         a = a + i + j;
//     }
// }

// Time Complexity => O(N) * O(N) => O(N^2)

//3. 
int i, j, k = 0;
int n = 32;
for (i = n / 2; i <= n; i++)
{
    Console.WriteLine(i); // n/2
    for (j = 2; j <= n; j = j * 2)
    {
        k = k + n / 2;
        Console.WriteLine("Value of J" + j); // logn
    }
}
// Time Complexity => O(n/2) * O(logn)=> O(nlogn)


//4.
int N = 20;
int a = 0;
i = N;
while (i > 0)
{
    a += i;
    i /= 2;
}


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
    while (number > 0) // 2 times 
    {
        int digit = number % 10; // extract the last digit.
        sum = sum + getFactorial(digit); // add the factorial to the sum.
        // 1 and 2 times 
        number = number / 10; // remove the last digit.
    }
    return copy == sum; // true other false
}

// while (12>0)
// 2 => getFactorial(2) => 2 (Runs 2 times)
// while (1>0)
// 1 => getFactorial(1) => 1 (Runs once)
// O(No of Digits * digit) 

// if (copy != sum)
// {
//     return false;
// }
// return true;
// return copy == sum ? true : false;


// Methods
// Time Complexity
// Thursday 1 -4 PM Online.