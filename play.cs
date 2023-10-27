Console.WriteLine("\nHappy Numbers check:");
Console.WriteLine("Please insert any number");
int number16 = int.Parse(Console.ReadLine());
int copy = number16;
int sum16 = 0;
int digit16 = 0;
//while loop
while (true)
{
    while (number16 > 0)
    {
        digit16 = number16 % 10; //extract the last digit
        sum16 = sum16 + (digit16 * digit16); //add the square of digit to the sum
        number16 = number16 / 10; //removing the last number
    }
    if (sum16 == 1)
    {
        Console.WriteLine("Happy number");
        break;
    }
    else if (sum16 == number16 || sum16 == 4)
    {
        // 4
        // 16 -> 1^2 + 6^2
        // 37 -> 9+49
        // 58 -> 25+64,
        // 89 -> 64 + 81
        // 145 -> 1+ 16+25
        // 42 -> 16 + 4
        // 20 -> 4+0=> 4 
        Console.WriteLine("This is not a happy number");
        break;
    }
    else
    {
        number16 = sum16;
    }
}