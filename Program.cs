// 1. Write a method to find and return the second largest element in an integer array. 
// Provide the method and an example. 

// Ex - [10, 13, -1, 2, 6, 7] => 10 is the second largest element 

static int getSecondLargestNumber(int[] array)
{

    // run the loop once. 
    // we take 2 variables
    // firstLargest
    // SecondLargest
    int firstLargest = int.MinValue;
    int SecondLargest = int.MinValue;
    // foreach loop
    foreach (int element in array)
    {
        if (element > firstLargest)
        {
            SecondLargest = firstLargest;
            firstLargest = element;
        }
        else if (element > SecondLargest && element != firstLargest)
        {
            SecondLargest = element;
        }
    }
    return SecondLargest;
}

// 2. Create a method that checks if a string contains only unique characters (no duplicates).  
// Ex – Hello -> duplicates present,
// Ex – bye -> no duplicates present 

// return type: bool
// input: string

static bool checkDuplicates(string str)
{
    // check duplicates
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 1; j < str.Length; j++)
        {
            if (str[i] == str[j])
            {
                //hello
                // h e, h l, h l, h 0
                // e l, e l, e 0
                // l l, => false
                return false;
            }
        }
    }
    return true;
}

// find a better solution. (HW)

// 3. Write a method that calculates the sum of the squares of the first n natural numbers.  
// Ex – 10, 1+2+3+4+5+6+7+8+9+10 => 55 

// return : int
// input: int

static int getSumOfNaturalNumber(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        //sum = sum + n;
        sum += n;
    }
    return sum;
}

// 4. Write a method that calculates the power of a number (x^n) without using the built-in Math.Pow function. (Use For /while Loop)
// Ex – x = 2, n = 2 => 2^2  => 4  

// return : int number, int power
// input: int

static int getPower(int number, int power)
{
    // if the number is negative;
    // -2^2 => -2 * -2 => 4
    // -2^3 => -2 * -2 * -2 =>-8
    if (number < 0)
    {
        power = 1 / power;
        number = -number;
    }
    int result = 1;
    for (int i = 1; i <= power; i++)
    {
        result = result * number;
    }
    return result;
}

//5. GCD
// Greatest Common Denominator
// return as int
// input : int a, int b

static int calculateGCD(int a, int b)
{
    // a/b, 3/0 => Infinity, 0/1 => undefined.
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;

        // 10/5
        // temp = 5
        // b = 10%5 => 0
        // a = 5
    }
    return a;
}