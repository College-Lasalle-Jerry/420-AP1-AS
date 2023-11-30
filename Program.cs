// Write a function that takes a non-empty of distinct integers and a target sum. (Use while loop) - O(n) Hint Array.Sort(array); 

// Array = [3,5, -4,8,11,1, -1,6] 

// Target Sum = 10 

// Output = [-1,11] // the order can be reversed. 


static int[] Sum(int[] array, int targetSum)
{

    Array.Sort(array);
    int left = 0;
    int right = array.Length - 1;
    while (left < right)
    {
        int currentSum = array[left] + array[right];
        if (currentSum == targetSum)
        {
            return new int[] { array[left], array[right] };
        }
        if (currentSum > targetSum)
        {
            right--;
        }
        if (currentSum < targetSum)
        {
            left++;
        }
    }
    return new int[0];
}

int[] sum = { 3, 5, -4, 8, 11, 1, -1, 6 };

int[] result = Sum(sum, 10);

Console.WriteLine(string.Join(",", result));


// Write a function that takes in a non-empty array and returns an array of the same length where each element in the output array is the product of each of the other elements in the input array. (Use For Loops) O(n) 

// Array = [5,1,4,2]

// Output = [8, 40, 10, 20] 


static int[] Products(int[] array)
{
    int[] products = new int[array.Length];

    int runningProduct = 1;

    // for loop in straight order
    for (int i = 0; i < array.Length; i++)
    {
        products[i] = runningProduct;
        runningProduct *= array[i];
    }
    runningProduct = 1;
    // for loop in reverse order
    for (int i = array.Length - 1; i >= 0; i--)
    {
        products[i] *= runningProduct;
        runningProduct *= array[i];
    }
    return products;
}

int[] products = { 5, 1, 4, 2 };

int[] result1 = Products(products);

Console.WriteLine(string.Join(",", result1));

