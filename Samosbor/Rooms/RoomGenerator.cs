using System.Drawing;

namespace Samosbor.Rooms;

public class RoomGenerator
{
    Random Random = new Random();
    public Floor GetFloor()
    {
        return new Floor { Texture = '.' };
    }
    public Wall GetWall()
    {
        return new Wall { Texture = (char)Random.Next(20, 60) };
    }
    public Size GetSize()
    {
        return new Size(Random.Next(10,20), Random.Next(10, 20));
    }
}