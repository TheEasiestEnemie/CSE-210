public class Word 
{
    private string word;
    private int wordLength;
    private char[] guessedWord;
    public Word(string word, int wordlength, char[] guessedWord)
    {
        Words newWord = new Words(word);

        word = newWord.rnword;
        wordLength = word.Length;
        guessedWord = new char[wordLength];
    }

    public char[] FormatGuessedWord(char[] guessedWord)
    {
        for (int i = 0; i < guessedWord.Length; i++)
        {
            guessedWord[i] = '_';
        }
        return guessedWord;
    }
}