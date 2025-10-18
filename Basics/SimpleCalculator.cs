using System;

class SimpleCalculator
{
    static void Main()
    {
        double num1, num2, result;
        char operation;

        num1 = 10;
        num2 = 5;
        operation = '+';  // Change this to '-', '*', or '/' to test other operations

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine("Result: " + result);
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator.");
                break;
        }
    }
}