using System;
using System.Collections.Generic;
using System.Data;
using CSE210_Assult.Game.Casting;
using CSE210_Assult.Game.Services;
using Raylib_cs;
using System.Numerics;


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
            BulletList bulletList = (BulletList)cast.GetFirstActor("bulletList");
            EnemyList enemyList = (EnemyList)cast.GetFirstActor("enemyList");
            List<Actor> bullets = bulletList.GetList();
            List<Actor> enemies = enemyList.GetList();
            List<int> bulletsToDestroy = new List<int>();
            List<int> enemiesToDestroy = new List<int>();
            Console.WriteLine(bullets.Count);
            for (int i = 0; i < bullets.Count; i++)
            {

                //Console.WriteLine("Loop works");
                Bullet bullet = (Bullet)bullets[i];
                Vector2 bulletPos = bullet.GetPosition();
                if ((bulletPos.X > Constants.MAX_X) || (bulletPos.Y > Constants.MAX_Y) ||
                (bulletPos.X < 0) || (bulletPos.Y < 0))
                {
                    //Console.WriteLine("Bullet out of Bounds at " + i);
                    bulletsToDestroy.Add(i);
                }
                else
                {
                    if (bullet.GetSource().Equals("player"))
                    {
                        for (int j = 0; j < enemies.Count; j++)
                        {
                            EnemyTank enemy = (EnemyTank)enemies[j];
                            bool hit = Raylib.CheckCollisionCircles(bullet.GetPosition(), (float)bullet.GetRadius(), 
                            enemy.GetPosition(), (float)enemy.GetRadius());
                            if (hit)
                            {
                                //Console.WriteLine("Enemy Hit! Index at: " + i + ", " + j);
                                bulletsToDestroy.Add(i);
                                enemiesToDestroy.Add(j);

                            }
                            /*else
                            {
                                //Console.WriteLine("No collisions detected.");
                            }*/
                            
                        }
                    }
                    else
                    {

                    }
                }
                
            }

            try {
                foreach (int index in enemiesToDestroy)
                {
                    enemyList.RemoveFromList(index);
                }
                foreach (int index in bulletsToDestroy)
                {
                    bulletList.RemoveFromList(index);
                }
            }
            catch(ArgumentOutOfRangeException e) {
                
            }
            finally {
                bulletsToDestroy.Clear();
                enemiesToDestroy.Clear();
            }
        }

        private void HandleGameOver(Cast cast)
        {
            if (isGameOver)
            {
                Console.WriteLine("GAME OVER!");
            }
        }

    }
}