using System;

class FibonacciSeries
{
    static void Main()
    {
        int terms = 10;
        int firstTerm = 0, secondTerm = 1;

        Console.WriteLine("Fibonacci Series up to {0} terms:", terms);
        for (int i = 1; i <= terms; i++)
        {
            Console.Write(firstTerm + " ");
            int nextTerm = firstTerm + secondTerm;
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }
    }
}