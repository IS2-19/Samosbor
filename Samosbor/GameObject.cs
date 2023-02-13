using Samosbor.Draws;

namespace Samosbor;

public class GameObject
{
    public virtual bool Collide { get; set; } = false;
    public virtual ConsoleColor Color { get; set; } = ConsoleColor.White;
    public virtual char Texture { get; set; } = '.';
    public virtual Point Position { get; set; } = new Point();
    public Size Size { get; set; } = new Size();

    public virtual VisualObjectPool GetVisual()
    {
        return new VisualObjectPool(new VisualObject[,] { { new VisualObject { Char = Texture, Color = Color } } });
    }
}
