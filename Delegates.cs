using System;

public delegate void Calculation(decimal val1, decimal val2, ref decimal result);

namespace Delegates
{
    public class Delegates
    {
        public Calculation myCal1;
        public Calculation myCal2;

        public static void Add(decimal val1, decimal val2, ref decimal result)
        {
            result = val1 + val2;
            Console.WriteLine("Addition: {0} + {1} = {2}", val1, val2, result);
        }

        public static void Sub(decimal val1, decimal val2, ref decimal result)
        {
            result = val1 - val2;
            Console.WriteLine("Subtraction: {0} - {1} = {2}", val1, val2, result);
        }

        static void Main(string[] args)
        {
            Delegates d = new Delegates();

            d.myCal1 = new Calculation(Add);
            d.myCal2 = new Calculation(Sub);

            decimal res = 0;

            d.myCal1(100.50m, 50.25m, ref res);
            d.myCal2(100.50m, 50.25m, ref res);
        }
        
    }
}