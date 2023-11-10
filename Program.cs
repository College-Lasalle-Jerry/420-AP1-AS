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

int[] array = { -1, 2, 4, 10, 15, 23 };

// i will terenay operators to print result;

Console.WriteLine(BinarySearchFunction(array, 15) == -1 ? "Element not Found" : "Element Found!");