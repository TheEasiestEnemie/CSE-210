
/*
If you have any questions about the class, check the blueprint.txt file.
*/
public class Display {
    /*
    These two arrays make up the Visual:
    Parachute:      Man:
    "  ___  "       "   O   "
    " /___\ "       "  /|\  "
    " \   / "       "  / \  "
    "  \ /  "
    The double backslashes are neccessary otherwise it thinks its an escape character like \n or \+
    */
    String[] parachute = new String[4] {"  ___  ", " /___\\ ", " \\   / ", "  \\ /  "};
    String[] man = new String[3] {"   O   ", "  /|\\  ", "  / \\  "};

    public void Visual(int stage) 
    {
        int startpoint = 4 - stage; // determines how much parachute is left

        if (stage != 0) // if the game isn't over
        {
            for (int i = startpoint; i < 4; i++)
            {
                Console.WriteLine(parachute[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(man[i]);
            }
        }
        else if (stage == 0) // When the game is over
        {
            man[0] = "   X   ";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(man[i]);
            }
        }
        Console.WriteLine();
        Console.WriteLine();
            
    }

    public static void PrintWord(char[] word)
    {
        int wordLength = word.Length;
        for (int i = 0; i < wordLength; i++)
        {
            Console.Write(word[i] + " "); // prints the word in a format "a p p l e
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    public static char Prompt()
    {
        char input;

        // This loop acts as a filter for unwanted characters
        do {

            Console.Write("Guess a letter [a-z]: ");
            input = Console.ReadKey(true).KeyChar;

        } while ((input >= 'A' && input <= 'Z') || (input >= 'a' && input <= 'z')); // chars can be compared to other chars

        // These lines convert the input to lowercase
        string str = input.ToString(); 
        str = str.ToLower();
        input = char.Parse(str);

        Console.WriteLine();
        Console.WriteLine();

        return input;
    }
}