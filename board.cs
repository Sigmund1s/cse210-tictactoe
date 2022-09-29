class Board 
{
    List<string> spaces = new List<string>();
    
    public Board()
    {
        for (int i = 1; i <= 9; i++)
        {
            spaces.Add(i.ToString());
        }
    }

    public bool IsPlayerIsWinner(string player)
    {
        // ----------------horizontal-------------------
        if (spaces[0] == player && spaces[1] == player && spaces[2] == player)
        {
            return true;
        }
        else if (spaces[3] == player && spaces[4] == player && spaces[5] == player)
        {
            return true;
        }
        else if (spaces[6] == player && spaces[7] == player && spaces[8] == player)
        {
            return true;
        }
        // ----------------Vertical-------------------
        if (spaces[0] == player && spaces[3] == player && spaces[6] == player)
        {
            return true;
        }
        else if (spaces[1] == player && spaces[4] == player && spaces[7] == player)
        {
            return true;
        }
        else if (spaces[2] == player && spaces[5] == player && spaces[8] == player)
        {
            return true;
        }

        // ----------------diagonal-------------------
        else if (spaces[0] == player && spaces[4] == player && spaces[8] == player)
        {
            return true;
        }
        else if (spaces[2] == player && spaces[4] == player && spaces[6] == player)
        {
            return true;
        }

        return false;
    }



    public bool ContainsUnclaimedSpaces() 
    {
        bool foundDigit = false;

        foreach (string value in board)
        {
            if (char.IsDigit(value[0]))
            {
                foundDigit = true;
                break;
            }
        }
        return !foundDigit
    }
















}