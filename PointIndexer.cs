using System;

class PointIndexer
{
    private int x;
    private int y;

    public int this[int index]
    {
        get
        {
            if (index == 0)
                return x;
            else if (index == 1)
                return y;
            else
                throw new IndexOutOfRangeException("Index must be 0 or 1.");
        }
        set
        {
            if (index == 0)
                x = value;
            else if (index == 1)
                y = value;
            else
                throw new IndexOutOfRangeException("Index must be 0 or 1.");
        }
    }

    public PointIndexer()
    {
        this.x = 0;
        this.y = 0;
    }  
    public PointIndexer(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    static void Main()
    {
        PointIndexer p1 = new PointIndexer();
        PointIndexer p2 = new PointIndexer(20, 10);

        Console.WriteLine("Point 1: ({0}, {1})", p1[0], p1[1]);
        Console.WriteLine("Point 2: ({0}, {1})", p2[0], p2[1]);
    }
}