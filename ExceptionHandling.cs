using System;

class ExceptionHandling
{
    static void Main()
    {
        double[] arr1 = { 10, 5, 2, 8, 4 };
        double[] arr2 = { 2, 1, 0, 4, 2 };

        try
        {
            if(arr1.Length != arr2.Length)
            {
                throw new IndexOutOfRangeException("Arrays must be of the same length.");
            }
            
            for (int i = 0; i < arr1.Length; i++)
            {
                double result = arr1[i] / arr2[i];
                Console.WriteLine("Result of {0} / {1} = {2}", arr1[i], arr2[i], result);
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed. " + ex.Message);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: Array index is out of bounds. " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        
    }
}