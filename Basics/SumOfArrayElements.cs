using System;

class SumOfArrayElements
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;

    // for (int i = 0; i < numbers.Length; i++)
    // {
    //     sum += numbers[i];
    // }
        foreach (int number in numbers)
        {
            sum += number;
        }
        
    Console.WriteLine("The sum of the array elements is: " + sum);
    }
}