public class Words
{
    // Word Library

    private String[] WordLibrary = new String[20] //add any words you want, just change the number in the array as well (20 words, String[20])
    {
        "apple", "water", "programming", "class", "method", "string",
        "integer", "public", "static", "void", "bracket", "statement",
        "while", "visual", "display", "word", "words", "jumper",
        "stack", "pizza"
    };

    public string NewWord()
    {
        int listLength = WordLibrary.Length;
        Random rn = new Random();
        int random = rn.Next(0, listLength);
        string rnword = WordLibrary[random];

        return rnword;
    }
}