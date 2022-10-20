
public class Word 
{
    private static string word;
    private static int wordLength;
    private char[] guessedWord;
    private char[] lastGuessedWord;
    public Word()
    {
        Words wordLibrary = new Words();

        word = Words.NewWord();
        wordLength = word.Length;
        guessedWord = new char[wordLength];
        lastGuessedWord = guessedWord;
    }

    public static string GetWord()
    {
        return word;
    }

    public static char[] FormatGuessedWord(char[] guessedWord)
    {
        for (int i = 0; i < guessedWord.Length; i++)
        {
            guessedWord[i] = '_';
        }
        return guessedWord;
    }

    public static char[] GuessLetters(char letter, string word, char[] guessedWord)
    {
        char[] wordArray = word.ToCharArray();

        for (int i = 0; i < wordLength; i++)
        {
            if (wordArray[i] == letter)
            {
                guessedWord[i] = letter;
            }
        }

        return guessedWord;
    }

    public static bool IsGuessCorrect(char[] guessedWord, char[] lastGuessedWord)
    {
        for (int i = 0; i < wordLength; i++)
        {
            if (guessedWord[i] != lastGuessedWord[i])
            {
                return true;
            }
        }
        return false;
    }

    public static bool AllLettersGuessed(char[] guessedWord)
    {
        for (int i = 0; i < wordLength; i++)
        {
            if (guessedWord[i] == '_')
            {
                return false;
            }
        }
        return true;
    }
}
