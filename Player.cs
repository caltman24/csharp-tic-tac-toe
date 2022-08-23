using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Player
{
    public char Mark { get; }
    public string Name { get; }

    public Player(char mark, string name)
    {
        Mark = mark;
        Name = name;
    }

    public void PickSpot(Board board)
    {
        string prompt = $"{Name}'s turn: ";

        Console.Write(prompt);
        string? choice = Console.ReadLine();

        while (!board.ValidatePlayerChoice(choice))
        {
            Console.WriteLine("Please enter a valid location (1-9)\n");
            Console.Write(prompt);
            choice = Console.ReadLine();
        }


        #pragma warning disable CS8604 // Possible null reference argument.
        char player1_choice =  Char.Parse(choice);
        #pragma warning restore CS8604 // Possible null reference argument.


        board.AddToBoard(player1_choice, Mark);
        board.SetBoard();
        
    }
}

