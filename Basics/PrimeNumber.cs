using System;

class  PrimeNumber
{
    static void Main()
    {
        int number = 29;
        int flag = 0;

        if (number <= 1)
        {
            flag = 1;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
        }

        if (flag == 0)
        {
            Console.WriteLine("{0} is a prime number.", number);
        }
        else
        {
            Console.WriteLine("{0} is not a prime number.", number);
        }
    }
}