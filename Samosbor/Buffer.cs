using System.Text;

namespace Samosbor;

public class Buffer
{
    private bool _isChanged = true;
    private string _charsCombined = "";
    private char[,] _chars;

    public Buffer(char[,] chars)
    {
        _chars = chars;
    }

    public string CombineChars()
    {
        if (!_isChanged) return _charsCombined;

        var sb = new StringBuilder();
        for (int i = 0; i < _chars.GetLength(0); i++)
        {
            for (int j = 0; j < _chars.GetLength(1); j++)
            {
                sb.Append(_chars[i, j]);
            }
            sb.Append('\n');
        }

        _isChanged = false;
        return _charsCombined = sb.ToString();
    }
    public char[,] Chars
    {
        get => _chars;
        set
        {
            _chars = value;
            _isChanged = true;
        }
    }
}
