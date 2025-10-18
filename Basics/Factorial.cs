using System;

class Factorial
{
    static void Main()
    {
        int number = 5;
        int factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("The factorial of {0} is: {1}", number, factorial);
    }
}