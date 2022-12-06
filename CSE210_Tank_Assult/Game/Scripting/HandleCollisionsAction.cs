using System;
using System.Collections.Generic;
using System.Data;
using System.Numerics;
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

            }
        }

    }
}