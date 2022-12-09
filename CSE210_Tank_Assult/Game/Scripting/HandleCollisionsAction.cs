using System;
using System.Collections.Generic;
using System.Data;
using CSE210_Assult.Game.Casting;
using CSE210_Assult.Game.Services;
using Raylib_cs;


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

            PlayerTank player = (PlayerTank)cast.GetFirstActor("player");
            List<Actor> bullets = cast.GetGroupActors("bullet");
            List<Actor> enemies = cast.GetGroupActors("enemy");
            List<Actor> thingsToDestroy = new List<Actor>();

            for (int b = 0; b < bullets.Count; b++)
            {
                Bullet bullet;
                if (bullets[b] is Bullet)
                {
                    bullet = (Bullet)bullets[b];
                    for (int i = 0; i < enemies.Count; i++)
                    {
                        EnemyTank enemy;
                        if (enemies[i] is EnemyTank)
                        {
                            enemy = (EnemyTank)enemies[i];
                            if (Raylib.CheckCollisionCircles(bullet.GetPosition(), (float)bullet.GetRadius(), 
                            enemy.GetPosition(), (float)enemy.GetRadius()));
                            {
                                thingsToDestroy.Add(bullet);
                                thingsToDestroy.Add(enemy);
                            }
                        }
                    }
                }
            }

            foreach (Actor entity in thingsToDestroy)
            {
                if (entity is EnemyTank)
                {
                    cast.RemoveActor("enemy", entity);
                }
                else if (entity is Bullet)
                {
                    cast.RemoveActor("bullet", entity);
                }
            }
        }

        private void HandleGameOver(Cast cast)
        {
            if (isGameOver)
            {
                

                // create a "game over" message
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
            }
        }

    }
}