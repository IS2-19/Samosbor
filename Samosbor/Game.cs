namespace Samosbor;

public class Game
{
    public Game(Buffer buffer)
    {
        _buffer = buffer;
    }
    private Buffer _buffer;
    private bool _isVisualActive = true;
    public void Run()
    {
        while (true)
        {
            if (_isVisualActive) Render();

            HandleInput();
        }
    }
    public void Render()
    {
        Console.Clear();
        Console.WriteLine(_buffer.CombineChars());
        Thread.Sleep(1000);
    }
    public void HandleInput()
    {
        var key = Console.ReadKey();
        if (key.Key == ConsoleKey.Q)
        {
            _isVisualActive = !_isVisualActive;
        }
    }
}
