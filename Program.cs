void BubbleSort(int[] array)
{
    int n = array.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            // check of the array[j] > array[j+1]
            if (array[j] > array[j + 1])
            {
                // swap the elements.
                // Method 1
                // int temp = array[j];
                // array[j] = array[j + 1];
                // array[j + 1] = temp;


                // Method 2 - Using reference.
                // Swap(ref array[j], ref array[j + 1]);

                // Method 3 - Simple Redirection
                (array[j], array[j + 1]) = (array[j + 1], array[j]);
            }
        }
    }
}

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}


int[] array = { 88, 11, 5, -1, 0, 64, 10 };
// Shorthand to print all the elements in an array.
Console.WriteLine("Before Sort => " + string.Join(',', array));
BubbleSort(array);
Console.WriteLine("After Sort => " + string.Join(',', array));


// Strings 
// Hint - string.compare(str1,str2)
// >0 (str1 is larger)
// <0 (str2 is larger)
// ==0 (st1 and str2 is same.)

void StringBubbleSort(string[] array)
{

    //Console.WriteLine("a -> " + (int)'a' + " \n A-> " + (int)'A');
    // your code here.
    int n = array.Length;

    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            // check
            if (string.Compare(array[j], array[j + 1], StringComparison.Ordinal) > 0)
            {
                (array[j], array[j + 1]) = (array[j + 1], array[j]);
            }
        }
    }
}

string[] StringArray = { "Apple", "Samsung", "Plum", "Asus", "Lasalle", "apple", "Toshiba" };


Console.WriteLine("Before Sort => " + string.Join(",", StringArray));

StringBubbleSort(StringArray);

Console.WriteLine("After Sort => " + string.Join(",", StringArray));

