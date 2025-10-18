using System;

class ReverseNum
{
    static void Main()
    {
        int num = 12345;
        int reversedNum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reversedNum = reversedNum * 10 + digit;
            num /= 10;
        }

        Console.WriteLine("The reversed number is: {0}", reversedNum);
    }
}