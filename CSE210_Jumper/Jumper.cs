public class Jumper
{
    public static void Main(String[] args)
    {
        int stage = 4;
        Word word = new Word();
        string hiddenWord = Word.GetWord();
        int wordLength = hiddenWord.Length;
        char[] guessedWord = new char[wordLength];
        char[] lastGuessedWord = new char[wordLength];

        guessedWord = Word.FormatGuessedWord(guessedWord);
        lastGuessedWord = Word.FormatGuessedWord(lastGuessedWord);

        Display.PrintWord(guessedWord);
        Display.Visual(stage);

        char guess = Display.Prompt();

        while (stage > 0 || !Word.AllLettersGuessed(guessedWord))
        {
            guessedWord = Word.GuessLetters(guess, hiddenWord, guessedWord);
            Display.PrintWord(guessedWord);

            bool letterInWord = Word.IsGuessCorrect(guessedWord, lastGuessedWord);

            if (!letterInWord) //If guess didnt get a new letter
            {
                //stage--;
                Console.WriteLine("Wrong");
            }
            lastGuessedWord = guessedWord;

            Display.Visual(stage);

            bool gameOver = Word.AllLettersGuessed(guessedWord);

            if (!gameOver)
            {
                guess = Display.Prompt();
            }
        }

        

    
    }
}
