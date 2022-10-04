public class Game 
{

    /// Gets a guess from the player. True if "h", false if "l"
    /// Takes no parameters
    /// returns a bool true or false 
    public bool GetGuess()
    {
        Console.Write("What is your guess (h, l");
        string? guess = Console.ReadLine();

        if (guess == "h")
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    /// Checks if the player's guess matches the outcome. The outcome 
    /// coming from the Card.IsHigher method
    /// Takes the bool guessHigher variable and the outcome
    /// returns True if the comparison matches (false == false or true == true),
    /// otherwise returns false.
    public bool IsGuessCorrect(bool guessHigher, bool outcome)
    {
        if (guessHigher == outcome)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    /// Adds or subtracts points based on IsGuessCorrect. If it is true,
    /// adds 100 to score, else subtracts 75.
    /// Takes the guess outcome (just IsGuessCorrect in a variable) and
    /// the score to add to.
    /// Returns an int of the new score
    public int ChangePoints(bool guessOutcome, int score)
    {
        if (guessOutcome)
        {
            score += 100;
            return score;
        }
        else 
        {
            score -= 75;
            return score;
        }
        
    }

    /// Checks to see if score is greater than zero. If it isn't, Game is over
    /// Takes the score variable to compare to
    /// Returns a bool True/False. True if score is <= 0
    public bool IsGameOver(int score)
    {
        if (score <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    /// Asks the user if they want to play another round
    /// Takes no parameters
    /// returns a bool True/False. True if answer is yes
    public bool PlayAgain()
    {
        Console.Write("Do you want to play another round?(YES/NO): ");
        string? play = Console.ReadLine();
        if (play == "YES")
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}