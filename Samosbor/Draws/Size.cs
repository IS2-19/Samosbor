namespace Samosbor.Draws;

public struct Size
{
    public Size(int height, int width)
    {
        Height = height;
        Width = width;
    }
    public Size() : this(1, 1) { }
    public int Height { get; set; }
    public int Width { get; set; }
}
