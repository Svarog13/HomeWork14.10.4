using System;

Console.WriteLine("Enter the digit for Factorial: ");
int digit = int.Parse(Console.ReadLine());
int factorial = 1;

if (digit < 0)
{
    Console.WriteLine("Factorial don't work with negative digit!");
}
else
{
    for (int i = 1; i <= digit; i++)
    {
        factorial *= i;
    }
}

Console.WriteLine($"Factorial of digit {digit} = {factorial}");
