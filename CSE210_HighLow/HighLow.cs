class program
{
    /// Put main logic here!
    void Main(String[] args)
        {
            Card card = new Card();
            Game game = new Game();

            int card1 = card.DrawCard();
            int card2 = card.DrawCard();
            bool outcome = card.IsHigher(card1, card2);
            bool guessHigher = game.GetGuess();
            

            game.GetGuess();
        }
}