bool playAgain = false;

do
{
    GameLoop();
    Console.WriteLine("Would you like to play again? 'y' for yes. Any other key to quit");
    string? answer = Console.ReadLine();
    if (!String.IsNullOrEmpty(answer) && answer == "y")
    {
        playAgain = true;
    } else
    {
        playAgain &= false;
    }
} while(playAgain);


Environment.Exit(0);
Console.ReadKey();

void GameLoop()
{
    Board board = new();
    Player player1 = new('X', "Player 1");
    Player player2 = new('O', "Player 2");
    board.SetBoard();

    do
    {
        player1.PickSpot(board);

        if (board.CheckForWin())
        {
            break;
        }

        player2.PickSpot(board);
    } while (!board.CheckForWin());

    Console.WriteLine("We have a winner!");
}