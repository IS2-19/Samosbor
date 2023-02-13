using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samosbor.Rooms;

public class Room
{
    private Floor _floor;
    private Wall _wall;
    private Size _size;

    public Room(RoomGenerator generator)
    {
        _floor = generator.GetFloor();
        _wall = generator.GetWall();
        _size = generator.GetSize();
    }
    public Buffer RoomBuffer 
    { 
        get
        {
            return new Buffer(GenerateChars());
        }
    }

    private char[,] GenerateChars()
    {
        char[,] chars = new char[_size.Width, _size.Height];

        for (int i = 0; i < _size.Width; i++)
        {
            for (int j = 0; j < _size.Height; j++)
            {
                if (i == 0 || i == _size.Width-1 || j == 0 || j == _size.Height-1)
                    chars[i,j] = _wall.Texture;
                else
                    chars[i, j] = _floor.Texture;
            }
        }

        return chars;
    }
}

public class Floor : GameObject
{
    public override bool Collide { get; set; } = false;
}public class Wall : GameObject
{
    public override bool Collide { get; set; } = true;
}