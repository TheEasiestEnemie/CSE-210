class program
{
    /// Put main logic here!
    static void Main(String[] args)
        {
            
            Card card = new Card();
            Game game = new Game();
            bool again = true;
            
            int card1 = card.DrawCard();
            int card2 = card.DrawCard();
            int score = 300;

            bool outcome;
            bool guessHigher;
            bool answer;

            while (again)
            {
                
                Console.WriteLine();
                Console.WriteLine($"Current card is {card1}");
                outcome = card.IsHigher(card1, card2);
                guessHigher = game.GetGuess();
                answer = game.IsGuessCorrect(guessHigher, outcome);
                Console.WriteLine($"Your card was {card2}");
                score = game.ChangePoints(answer, score);
                Console.WriteLine($"Your new score is {score}");
                if (game.IsGameOver(score) == false)
                {
                    again = game.PlayAgain();
                    
                }
                else
                {
                    again = false;
                }
                
                if (again)
                {
                    card1 = card2;
                    card2 = card.DrawCard();

                    
                }

                
            }
        }
}