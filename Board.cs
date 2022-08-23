using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Board
{
    private readonly char[,] _board = {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };

    public void SetBoard()
    {
        Console.Clear();
        Console.WriteLine("-------------");
        Console.WriteLine($"| {_board[0, 0]} | {_board[0, 1]} | {_board[0, 2]} |");
        Console.WriteLine("|---|---|---|");
        Console.WriteLine($"| {_board[1, 0]} | {_board[1, 1]} | {_board[1, 2]} |");
        Console.WriteLine("|---|---|---|");
        Console.WriteLine($"| {_board[2, 0]} | {_board[2, 1]} | {_board[2, 2]} |");
        Console.WriteLine("-------------");
        Console.WriteLine("");
    }

    public bool ValidatePlayerChoice(string? choice)
    {
        // return false if null or it cant parse to a Char
        if (!Char.TryParse(choice, out _) || String.IsNullOrEmpty(choice))
        {
            return false;
        }


        // Check if the parsed choice(Char) is a spot in the board 
        char parsedChoice = Char.Parse(choice);
        foreach (char c in _board)
        {
            if (parsedChoice == c)
                return true;
        }
        return false;
    }

    public void AddToBoard(char? choice, char mark)
    {
        switch(choice)
        {
            case '1': _board[0, 0] = mark; break;
            case '2': _board[0, 1] = mark; break;
            case '3': _board[0, 2] = mark; break;
            case '4': _board[1, 0] = mark; break;
            case '5': _board[1, 1] = mark; break;
            case '6': _board[1, 2] = mark; break;
            case '7': _board[2, 0] = mark; break;
            case '8': _board[2, 1] = mark; break;
            case '9': _board[2, 2] = mark; break;
        }
    }

    public bool CheckForWin()
    {
        // Check for win across rows
        if ((_board[0, 0] == _board[0, 1] && _board[0, 0] == _board[0, 2]) ||
            (_board[1, 0] == _board[1, 1] && _board[1, 0] == _board[1, 2]) ||
            (_board[2, 0] == _board[2, 1] && _board[2, 0] == _board[2, 2]) )
        {
            return true;
        }

        // Check for win across columns
        if ((_board[0, 0] == _board[1, 0] && _board[0, 0] == _board[2, 0]) ||
            (_board[0, 1] == _board[1, 1] && _board[0, 1] == _board[2, 1]) ||
            (_board[0, 2] == _board[1, 2] && _board[0, 2] == _board[2, 2]))
        {
            return true;
        }

        // Check for diagnal wins
        if ((_board[0, 0] == _board[1, 1] && _board[0, 0] == _board[2, 2]) ||
            (_board[0, 2] == _board[1, 1] && _board[0, 2] == _board[2, 2]))
        {
            return true;
        }

        return false;

    }
}


