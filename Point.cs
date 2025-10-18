using System;

class Point
{
    private int x;
    private int y;

    private static int pointCount = 0;

    static Point()
    {
        pointCount = 0;
        //Static constructor called. Point count initialized to zero.
    }

    public Point()
    {
        this.x = 0;
        this.y = 0;
        pointCount++;
    }
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
        pointCount++;
    }

    public int getX()
    {
        return x;
    }
    public int getY()
    {
        return y;
    }

    public static int GetPointCount()
    {
        return pointCount;
    }

    static void Main()
    {
        Point p1 = new Point();
        Point p2 = new Point(3, 4);
        Point p3 = new Point(5, 6);

        Console.WriteLine("Point 1: ({0}, {1})", p1.getX(), p1.getY());
        Console.WriteLine("Point 2: ({0}, {1})", p2.getX(), p2.getY());
        Console.WriteLine("Point 3: ({0}, {1})", p3.getX(), p3.getY());

        Console.WriteLine("Total Points created: {0}", Point.GetPointCount());
    }
}