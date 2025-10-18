using System;

class LargestOfTwoNum
{
    static void Main()
    {
        int num1 = 10;
        int num2 = 20;
        int largest;

        if (num1 > num2)
        {
            largest = num1;
        }
        else
        {
            largest = num2;
        }

        Console.WriteLine("The largest number between {0} and {1} is: {2}", num1, num2, largest);
    }
}