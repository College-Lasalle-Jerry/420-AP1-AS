// Linear Search


// we have an array (int), and we need to find if a value is present or not.
// 10,15,23,-1,2,4
// find -1

// static string search(int[] array, int search)
// {

//     foreach (int element in array)
//     {
//         if (element == search)
//         {
//             return "Element found!";
//         }
//     }
//     return "Element not found";
// }

// int[] array = { 10, 15, 23, -1, 2, 4 };
// Console.WriteLine("Enter an element to search.");
// int searchElement = int.Parse(Console.ReadLine());
// string result = search(array, searchElement);
// Console.WriteLine(result);


// Compare the middle element of the search space with the key. 
// If the key is found at middle element, the process is terminated.
// If the key is not found at middle element, choose which half will be used as the next search space.
// If the key is smaller than the middle element, then the left side is used for next search.
// If the key is larger than the middle element, then the right side is used for next search.
// This process is continued until the key is found or the total search space is exhausted.


static int BinarySearchFunction(int[] array, int searchElement)
{
    int left = 0, right = array.Length - 1;
    // Loop

    while (left <= right)
    {
        int middle = left + (right - left) / 2; // to avoid overflow.
        // if middle element of array is equal to the searchElement.
        if (array[middle] == searchElement)
        {
            return middle;
        }
        // if the se if greate than middle element.
        if (searchElement > array[middle])
        {
            left = middle + 1;
        }
        else
        {
            right = middle - 1;
        }
    }

    return -1; // if no element is found we return -1
}



// i will terenay operators to print result;

// Console.WriteLine(BinarySearchFunction(array, 15) == -1 ? "Element not Found" : "Element Found!");


// Compare Characters
// https://yorktown.cbe.wwu.edu/sandvig/shared/asciicodes.aspx

// A-Z => 65 - 90
// a-z => 97 - 122

// char ch = 'b';
// Console.WriteLine('a' > 'A'); // true or false??




// Binary Search - Characters

char[] characterArray = { 'A', 'B', 'C', 'Z', 'b', 'd', 'g', 'z' };
// search -> b 

// return is boolean
static bool checkCharacter(char[] chars, char search)
{

    //Type your code here.
    int left = 0, right = chars.Length - 1;
    // while loop

    while (left <= right) // condition is met.
    {
        int middle = left + (right - left) / 2;
        // to avoid overflow.
        if (chars[middle] == search)
        {
            return true;
        }
        if (search > chars[middle])
        {
            left = middle + 1; // middle is already checked
        }
        else
        {
            right = middle - 1; // // middle is already checked
        }
    }
    return false;
}


Console.WriteLine(checkCharacter(characterArray, 'b'));


// Compare Strings - comparing two strings is based on the dictionary concept.

String s1 = "apple";
String s2 = "apple";

Console.WriteLine(string.Compare(s2, s1));
// -1 , s1 is bigger.
// 1, s2 is bigger.
// 0, both are equal.

// Binary Search - Strings

string[] sortedStringArray = { "apple", "banana", "cherry", "date", "fig", "grape", "kiwi" };

static bool searchStrings(String[] array, String target)
{
    // Your code will here.

    int left = 0, right = array.Length - 1;
    while (left <= right)
    {
        int middle = left + (right - left) / 2;// to avoid overflow problems.
        int comparison = string.Compare(array[middle], target);
        if (comparison == 0)
        {
            return true;
        }
        // target is greater
        if (comparison < 0)
        {
            left = middle + 1;
        }
        else
        {
            right = middle - 1;
        }
    }
    return false;
}

// Q. Use Binary Search to search for an element in integer array.
// If found replace the value with the factorial of the number,
// If not found display a message stating not found.

// hint - 2 functions, 
// 1. Binary Search
//2. factorial
// 3. check if target is found. 
// replce value accordinly.

int[] array = { -1, 2, 4, 10, 15, 23 };
int target = 100;
int index = BinarySearchFunction(array, target);


static int getFactorial(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact = fact * i;
    }
    return fact;
}
if (index < 0)
{
    Console.WriteLine("Element not Found!");
}
else
{
    int factorial = getFactorial(target);
    array[index] = factorial;
    foreach (int element in array)
    {
        Console.WriteLine(element);
    }
}

// To implement Binary Search, you need a sorted array.
// Return - index positon or a boolean value
