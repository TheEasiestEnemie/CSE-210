class Card
{
    /// "Draws" a card numbered 1-13 using the random method
    /// Takes no parameters
    /// Returns an int 1-13
    public int DrawCard()
    {
        Random num = new Random();
        int card = num.Next(1, 14);

        return card;
    }

    /// Compares Card1 to Card2 and is true if Card2 is higher
    /// Takes 2 parameters: 2 ints labeled card1 and card2
    /// Returns a bool True or False
    public bool IsHigher(int card1, int card2)
    {
        while (true)
        {
            if (card2 > card1)
            {
                return true;
            }
            else if (card2 < card1) 
            {
                return false;
            }
        }
    }
}