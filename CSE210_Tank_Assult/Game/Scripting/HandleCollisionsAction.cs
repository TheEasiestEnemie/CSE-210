using System;
using System.Collections.Generic;
using System.Data;
using CSE210_Assult.Game.Casting;
using CSE210_Assult.Game.Services;


namespace CSE210_Assult.Game.Scripting
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
        private bool isGameOver = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (!isGameOver)
            {
                HandleGameOver(cast);
            }
        }

        private void HandleGameOver(Cast cast)
        {
            if (isGameOver)
            {
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