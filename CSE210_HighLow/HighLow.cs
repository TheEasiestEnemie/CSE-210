public class HighLow 
{
    /// Put main logic here!
    public static void Main(String[] args)
    {

    }

    /// Gets a guess from the player. True if "h", false if "l"
    /// Takes no parameters
    /// returns a bool true or false 
    public GetGuess()`
    {

    }

    /// Checks if the player's guess matches the outcome. The outcome 
    /// coming from the Card.IsHigher method
    /// Takes the bool guessHigher variable and the outcome
    /// returns True if the comparison matches (false == false or true == true),
    /// otherwise returns false.
    public IsGuessCorrect(bool guessHigher, bool outcome)
    {

    }
    /// Adds or subtracts points based on IsGuessCorrect. If it is true,
    /// adds 100 to score, else subtracts 75.
    /// Takes the guess outcome (just IsGuessCorrect in a variable) and
    /// the score to add to.
    /// Returns an int of the new score
    public ChangePoints(bool guessOutcome, int score)
    {

    }

    /// Checks to see if score is greater than zero. If it isn't, Game is over
    /// Takes the score variable to compare to
    /// Returns a bool True/False. True if score is <= 0
    public IsGameOver(int score)
    {

    }
    /// Asks the user if they want to play another round
    /// Takes no parameters
    /// returns a bool True/False. True if answer is yes
    public PlayAgain()
    {

    }
}