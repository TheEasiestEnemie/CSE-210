using CSE210_Assult.Game.Casting;
using CSE210_Assult.Game.Services;
using System.Numerics;


namespace CSE210_Assult.Game.Scripting
{
    /// <summary>
    /// <para>An input action that controls the snake.</para>
    /// <para>
    /// The responsibility of ControlActorsAction is to get the direction and move the snake's head.
    /// </para>
    /// </summary>
    public class HandlesEnemiesAction : Action
    {
        private Vector2 direction;
        private float subSpeed = 2;
        private bool hasShot = false;
        public HandlesEnemiesAction()
        {

        }

        public void Execute(Cast cast, Script script)
        {
            List<Actor> enemy = cast.GetGroupActors("enemy");
        }
    }

    
}