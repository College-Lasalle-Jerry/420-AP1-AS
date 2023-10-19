// Swapping 2 numbers

int a = 15;
int b = 100;

// you have to swap 2 numbers 
// a= 20, b=10

// 1st method
int temp;
temp = a;
a = b;
b = temp;


// Second Method
// Ideal when we have positive numbers (integers). 
// a = a + b;
// b = a - b;
// a = a - b;

Console.WriteLine($"a is {a}");
Console.WriteLine($"b is {b}");

//Bubble Sort.
//Bubble Sort is the simplest sorting algorithm that works
//by repeatedly swapping the adjacent elements if they are in the wrong order.
//This algorithm is not suitable for large data sets as its average 
//and worst-case time complexity is quite high.
int[] arr = { 5, 3, 1, 4, 2 };

for (int i = 0; i < 20; i++)
{
    for (int j = 0; j < 30; j++)
    {
        // 10 * 10 = 100
        // 10 * 30 = 300
        // 20 * 30 = 600

        // i is running upto n times
        // j is running upto m times
        // the total number of iterations will be n*m
        // Time complexity in programming is denoted by O() (Big O)
        // O(n*m) AVGERAGE CASE
        // O(n*n) Worst case => O(n^2) 
        // O(n^2) is the worst case in programming.
    }
}



