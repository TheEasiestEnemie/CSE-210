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
    public class ControlActorsAction : Action
    {
        private KeyboardService keyboardService;
        private MouseServices mouseServices;
        private Vector2 direction = new Vector2(0, 0);
        private float subSpeed = (float)Math.Sqrt(Math.Pow(Constants.PLAYER_SPEED, 2) / 2);

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public ControlActorsAction(KeyboardService keyboardService, MouseServices mouseServices)
        {
            this.keyboardService = keyboardService;
            this.mouseServices = mouseServices;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            // left
            if (keyboardService.IsKeyDown("a"))
            {
                if (keyboardService.IsKeyDown("w")) {
                    direction.X = -subSpeed;
                    direction.Y = -subSpeed;
                }

                else if (keyboardService.IsKeyDown("s")) {
                    direction.X = -subSpeed;
                    direction.Y = subSpeed;
                }

                else {
                    direction.X = -Constants.PLAYER_SPEED;
                }
            }

            // right
            if (keyboardService.IsKeyDown("d"))
            {
                if (keyboardService.IsKeyDown("w")) {
                    direction.X = subSpeed;
                    direction.Y = -subSpeed;
                }

                else if (keyboardService.IsKeyDown("s")) {
                    direction.X = subSpeed;
                    direction.Y = subSpeed;
                }

                else {
                    direction.X = Constants.PLAYER_SPEED;
                }
            }

            // up
            if (keyboardService.IsKeyDown("w"))
            {
                direction.Y = -subSpeed;
            }

            // down
            if (keyboardService.IsKeyDown("s"))
            {
                direction.Y = subSpeed;
            }

            else {
            }

            PlayerTank player = (PlayerTank)cast.GetFirstActor("player");
            player.SetVelocity(direction);

            direction = new Vector2(0, 0);
        }
    }
}

