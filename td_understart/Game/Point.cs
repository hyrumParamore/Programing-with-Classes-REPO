


public class Point
{

    private int x = 0;
    private int y = 0;



    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }


    // Adds the given point to this one by summing the x and y values.
    public Point Add(Point other)
    {
        int x = this.x + other.GetX();
        int y = this.y + other.GetY();
        return new Point(x, y);
    }


    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }


    // Scales the point by multiplying the x and y values by the provided factor.
    public Point Scale(int factor)
    {
        int x = this.x * factor;
        int y = this.y * factor;
        return new Point(x, y);
    }







}