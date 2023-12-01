static void SelectionSort(int[] array)
{
    // your code here.
    int n = array.Length;

    // outerloop - to select each element.
    for (int i = 0; i < n; i++)
    {
        int minIndex = i;
        // inner Loop - travese through the remaining elements, (i is not included).
        for (int j = i + 1; j < n; j++)
        {
            if (array[j] < array[minIndex])
            {
                minIndex = j; // We update the index not the value.
            }
        }
        // swap the value.
        (array[i], array[minIndex]) = (array[minIndex], array[i]);
    }

}


static void StringSelectionSort(string[] array)
{
    // Your code here.
}


// int[] array = { 64, 25, 12, 22, 11 };

string[] array = { "appLE", "aPPle", "Samsung", "Apple", "GooseBerry", "Cherry" };
Console.WriteLine("Original Array: " + string.Join(", ", array));

StringSelectionSort(array);

Console.WriteLine("Sorted Array: " + string.Join(", ", array));