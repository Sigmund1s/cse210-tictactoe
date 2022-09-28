﻿class TicTacToe
{
    static void Main(string[] args)
    {

        List<string> board = GetNewBoard();
        string currentPlayer = "x";

        while (!IsGameOver(board))
        {
            DisplayBoard(board);

            int choice = GetMoveChoice(currentPlayer);
            MakeMove(board, choice, currentPlayer);

            currentPlayer = GetNextPlayer(currentPlayer);
        }

        DisplayBoard(board);
        Console.WriteLine("Good game. Thanks for playing!");
    }

    /// <summary>Gets a new instance of the board with the numbers 1-9 in place. </summary>
    /// <returns>A list of 9 strings representing each square.</returns>

    static List<string> GetNewBoard()
    {
        List<string> board = new List<string>();
        for (int i = 1; i <= 9; i++)
        {
            board.Add(i.ToString());
        }

        /**
        NOTE: THIS IS AN ARRAY, then returned into a list "List"

        string[] numbers = {"1", "2", "3"};
        return new List<string>(numbers);
        **/
        return board;
    }


    /// <summary>Displays the board in a 3x3 grid.</summary>
    /// <param name="board">The board</param>
    static void DisplayBoard(List<string> board)
    {
        Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
    }


    /// <summary>
    /// Determines if the game is over because of a win or a tie.
    /// </summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the game is over</returns>
    static bool IsGameOver(List<string> board)
    {
        return IsWinner(board, "x") || IsWinner(board, "o") || IsTie(board);

        //or
        /***if (IsWinner(board, "x") || IsWinner(board, "o") || IsTie(board))
        {
            return true;
        }
        else 
        {
            return false;
        }***/
    }

    /// <summary>Determines if the provided player has a tic tac toe.</summary>
    /// <param name="board">The current board</param>
    /// <param name="player">The player to check for a win</param>
    /// <returns></returns>
    static bool IsWinner(List<string> board, string player)
    {
        // ----------------horizontal-------------------
        if (board[0] == player && board[1] == player && board[2] == player)
        {
            return true;
        }
        else if (board[3] == player && board[4] == player && board[5] == player)
        {
            return true;
        }
        else if (board[6] == player && board[7] == player && board[8] == player)
        {
            return true;
        }
        // ----------------Vertical-------------------
        if (board[0] == player && board[3] == player && board[6] == player)
        {
            return true;
        }
        else if (board[1] == player && board[4] == player && board[7] == player)
        {
            return true;
        }
        else if (board[2] == player && board[5] == player && board[8] == player)
        {
            return true;
        }

        // ----------------diagonal-------------------
        else if (board[0] == player && board[4] == player && board[8] == player)
        {
            return true;
        }
        else if (board[2] == player && board[4] == player && board[6] == player)
        {
            return true;
        }

        return false;
    }

    /// <summary>Determines if the board is full with no more moves possible.</summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the board is full.</returns>
    static bool IsTie(List<string> board)
    {
        // I would personally count all the moves made, if that equals up to 9. Its a draw.
        return false;
    }

    /// <summary>Cycles through the players (from x to o and o to x)</summary>
    /// <param name="currentPlayer">The current players sign (x or o)</param>
    /// <returns>The next players sign (x or o)</returns>
    static string GetNextPlayer(string currentPlayer)
    {
        if (currentPlayer == "x")
        {
            return "o";
        }
        else
        {
            return "x";
        }
    }

    /// <summary>Gets the 1-based spot number associated with the user's choice.</summary>
    /// <param name="currentPlayer">The sign (x or o) of the current player.</param>
    /// <returns>A 1-based spot number (not a 0-based index)</returns>
    static int GetMoveChoice(string currentPlayer)
    {
        if (currentPlayer == "x")
        {
            return 1;
        }
        else 
        {
            return 1;
        }
        
    }

    /// <summary>
    /// Places the current players mark on the board at the desired spot.
    /// This method does NOT check to ensure the spot is available.
    /// </summary>
    /// <param name="board">The current board</param>
    /// <param name="choice">The 1-based spot number (not a 0-based index).</param>
    /// <param name="currentPlayer">The current player's sign (x or o)</param>
    static void MakeMove(List<string> board, int choice, string currentPlayer)
    {
        
        if (currentPlayer == "x")
        {

        }
    }
}
