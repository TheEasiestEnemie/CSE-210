class program
{
    /// Put main logic here!
    static void Main(String[] args)
        {
            
            Card card = new Card();
            Game game = new Game();
            int test = card.DrawCard();
            Console.WriteLine(test);

            while (game.PlayAgain() != false)
            {
                int score = 500;
                int card1 = card.DrawCard();
                int card2 = card.DrawCard();
                Console.WriteLine($"Current card is {card1}");
                bool outcome = card.IsHigher(card1, card2);
                bool guessHigher = game.GetGuess();
                bool answer = game.IsGuessCorrect(guessHigher, outcome);
                score = game.ChangePoints(answer, score);

                

                game.GetGuess();
            }
        }
}