namespace Console.UI;

using System;
public class ConsoleTable
{
    private char HORIZONTAL = '-';
    private char VERTICAL = '|';
    int _rows { get; set; }
    int _columns { get; set; }

    public ConsoleTable(int rows, int columns)
    {
        _rows = rows;
        _columns = columns;
    }

    public void Draw()
    {
        int maxRows = Console.WindowHeight;
        int maxColumns = Console.WindowWidth;
        int colWidth = (maxColumns-1) / _columns;
        for (int r = 0; r < Math.Min(_rows, maxRows); r++)
        {
            for (int c = 0; c < _columns; c++)
            {
                Console.SetCursorPosition(c * colWidth, r);
                Console.Write($"{VERTICAL} ({c} , {r}) ");
            }
        }
    }
}
