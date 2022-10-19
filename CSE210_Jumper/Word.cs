
public class Word 
{
    private string word;
    private int wordLength;
    private char[] guessedWord;
    private char[] lastGuessedWord;
    public Word(string word, int wordlength, char[] guessedWord)
    {
        Words wordLibrary = new Words();

        word = Words.NewWord();
        wordLength = word.Length;
        guessedWord = new char[wordLength];
        lastGuessedWord = guessedWord;
    }

    public char[] FormatGuessedWord(char[] guessedWord)
    {
        for (int i = 0; i < guessedWord.Length; i++)
        {
            guessedWord[i] = '_';
        }
        return guessedWord;
    }

    public char[] GuessLetters(char letter, string word, char[] guessedWord)
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

    public bool IsGuessCorrect(char[] guessedWord, char[] lastGuessedWord)
    {
        for (int i = 0; i < wordLength; i++)
        {
            if (guessedWord[i] == lastGuessedWord[i])
            {
                return true;
            }
        }
        return false;
    }
}
