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

// for (int i = 0; i < 20; i++)
// {
//     for (int j = 0; j < 30; j++)
//     {
//         // 10 * 10 = 100
//         // 10 * 30 = 300
//         // 20 * 30 = 600

//         // i is running upto n times
//         // j is running upto m times
//         // the total number of iterations will be n*m
//         // Time complexity in programming is denoted by O() (Big O)
//         // O(n*m) AVGERAGE CASE
//         // O(n*n) Worst case => O(n^2) 
//         // O(n^2) is the worst case in programming.
//     }
// }



// Section 1 - MCQ
// Section 2 - Find the bug, predict the output.
// Section 3 -  5 Programming questions
// 2 are on menu selection, 1 patter question, 2 mix of all.


// Predict the Output
char grade = 'A';
switch (grade)
{
    case 'A':
    case 'B':
        Console.WriteLine("Good");
        break;
    default:
        Console.WriteLine("Average");
        break;
}


a = 5;
b = 3;
int c = 8;

Console.WriteLine(a < b || b < c);

// true or false?

int x = 5;
int y = ++x + x++; // 5 + 7 // ++x (prefix), x++ (postfix)
Console.WriteLine(y);


// ++x

// x = 5 (In memory and the display)
// ++x (It updates but the memory, it is not displayed)
// x++ (6, returns the current value, then it adds, 7)


x = 10;
y = 0;
x = x-- + y;
Console.WriteLine(x);

// 10


int m = 4;
int n = m++ - ++m;
Console.WriteLine(n);

// m++ (4) - ++m (5) = -1


int p = 3;
int q = 4;
int r = p-- * ++q;
Console.WriteLine(r); // 12


a = 5;
b = a-- + --a;
Console.WriteLine(b);
// 8


// a-- return 5, and decrements to 4
// --a decrement to 3, and return the new the value (3)




x = 5;
y = ++x - x-- + x;
Console.WriteLine($"x = {x}, y = {y}");

// x= 5, y= 5

// ++x increment to 6 and return 6
// -
// x-- return 6, and decrements to 5
// x is 5
// 6 - 6 + 5 => 5

x = 5;
y = x++ + ++x - x-- - --x;
Console.WriteLine($"x = {x}, y = {y}");
// x=5, y=0

// x++ => 5 (6)
// ++x => 7
// x-- => 7(6)
// --x => 5

// 5 + 7 - 7 - 5
// 0


m = 2;
n = m-- + --m * m;
Console.WriteLine($"m = {m}, n = {n}");


// BODMAS (Brackets of Division, Multiplication, Addition and Subtraction)
// m--, 2 (1)

// --m, 0
// m, 2


// m 2, n = 2



p = 10;
q = ++p + --p + p-- - ++p;
Console.WriteLine($"p = {p}, q = {q}");


// p=10, q=21

// ++p, 11
// --p, 10
// p--, 10 (9)
//++p, 10

// 11 + 10 + 10 - 10 = 21

int result = 0;
for (int i = 0; i < 5; i++)
{
    result = result + i++ + ++i;
}
Console.WriteLine(result);


// 1st Iternation
// i = 0 (1), result=0
// 0 + 0(1) + 2 => 2


// i = 2, result=2
// i= 2(3), result=2
// 2 + 3(4) + 5 => 10 