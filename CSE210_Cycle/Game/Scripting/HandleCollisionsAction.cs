using System;
using System.Collections.Generic;
using System.Data;
using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An update action that handles interactions between the actors.</para>
    /// <para>
    /// The responsibility of HandleCollisionsAction is to handle the situation when the snake 
    /// collides with the food, or the snake collides with its segments, or the game is over.
    /// </para>
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        private bool isGameOver1 = false;
        private bool isGameOver2 = false;

        private bool isGameOver3 = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (isGameOver1 == false && isGameOver2 == false && isGameOver3 == false)
            {
                HandleFoodCollisions(cast);
                HandleSegmentCollisions(cast);
                HandleGameOver(cast);
            }
        }

        /// <summary>
        /// Updates the score nd moves the food if the snake collides with it.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleFoodCollisions(Cast cast)
        {
            Snake snake = (Snake)cast.GetFirstActor("snake");
            Score score = (Score)cast.GetFirstActor("score");
            Food food = (Food)cast.GetFirstActor("food");
            
            if (snake.GetHead().GetPosition().Equals(food.GetPosition()))
            {
                int points = food.GetPoints();
                snake.GrowTail(points);
                score.AddPoints(points);
                food.Reset();
            }
        }

        /// <summary>
        /// Sets the game over flag if the snake collides with one of its segments.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleSegmentCollisions(Cast cast)
        {
            Snake snake = (Snake)cast.GetFirstActor("snake");
            Snake snake2 = (Snake)cast.GetFirstActor("snake2");
            Actor head = snake.GetHead();
            Actor head2 = snake2.GetHead();
            List<Actor> body = snake.GetBody();
            List<Actor> body2 = snake2.GetBody();

            foreach (Actor segment in body)
            {
                if (head.GetPosition().Equals(head2.GetPosition()))
                {
                    isGameOver3 = true;
                }
                else if (segment.GetPosition().Equals(head.GetPosition()))
                {
                    isGameOver1 = true;
                }
                else if (segment.GetPosition().Equals(head2.GetPosition()))
                {
                    isGameOver2 = true;
                }
                
            }
            
            foreach (Actor segment2 in body2)
            {
                if (head.GetPosition().Equals(head2.GetPosition()))
                {
                    isGameOver3 = true;
                }
                else if (segment2.GetPosition().Equals(head2.GetPosition()))
                {
                    isGameOver2 = true;
                }
                else if (segment2.GetPosition().Equals(head.GetPosition()))
                {
                    isGameOver1 = true;
                }
            }

            
        }

        private void HandleGameOver(Cast cast)
        {
            if (isGameOver1 == true || isGameOver2 == true || isGameOver3 == true)
            {
                Snake snake = (Snake)cast.GetFirstActor("snake");
                Snake snake2 = (Snake)cast.GetFirstActor("snake2");
                Actor head = snake.GetHead();
                Actor head2 = snake2.GetHead();
                List<Actor> segments = snake.GetSegments();
                List<Actor> segments2 = snake2.GetSegments();
                Food food = (Food)cast.GetFirstActor("food");

                // create a "game over" message
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);

                Actor message = new Actor();
                message.SetText("Game Over!");
                message.SetPosition(position);
                cast.AddActor("messages", message);

                // make everything white
                
                if (isGameOver1)
                {
                    foreach (Actor segment in segments)
                    {
                        segment.SetColor(Constants.WHITE);
                    }
                
                }

                else if (isGameOver2)
                {
                    foreach (Actor segment in segments2)
                    {
                        segment.SetColor(Constants.WHITE);
                    }
                }
                else if (isGameOver3)
                {
                    foreach (Actor segment in segments2)
                    {
                        segment.SetColor(Constants.WHITE);
                    }
                    foreach (Actor segment in segments)
                    {
                        segment.SetColor(Constants.WHITE);
                    }
                }

                food.SetColor(Constants.WHITE);
            }
        }

    }
}