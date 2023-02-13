namespace Samosbor.Draws;

public struct Point
{
    public Point(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public Point(int x, int y) : this(x, y, 0) { }
    public Point() : this(0,0,0) { }
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
}
