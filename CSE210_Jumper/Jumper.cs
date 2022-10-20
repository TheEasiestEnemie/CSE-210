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


        bool letterInWord = false;
        bool gameOver = false;
        string guessedStr;

        while (stage > 0 && !gameOver)
        {
            guessedWord = Word.GuessLetters(guess, hiddenWord, guessedWord);
            Display.PrintWord(guessedWord);

            letterInWord = Word.IsGuessCorrect(guessedWord, lastGuessedWord);

            if (!letterInWord) //If guess didnt get a new letter
            {
                stage--;
                
            }
            guessedStr = new string(guessedWord);
            lastGuessedWord = guessedStr.ToCharArray();

            Display.Visual(stage);

            gameOver = Word.AllLettersGuessed(guessedWord);

            if (!gameOver && stage > 0)
            {
                guess = Display.Prompt();
            }
        }

        

    
    }
}
