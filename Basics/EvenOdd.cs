using System;

class EvenOdd
{
    static void Main()
    {
        int number=10;

        if (number % 2 == 0)
        {
            Console.WriteLine("{0} is an even number.", number);
        }
        else
        {
            Console.WriteLine("{0} is an odd number.", number);
        }
    }
}