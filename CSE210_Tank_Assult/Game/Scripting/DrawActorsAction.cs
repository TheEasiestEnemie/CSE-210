using CSE210_Assult.Game.Casting;
using CSE210_Assult.Game.Services;


namespace CSE210_Assult.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Action
    {
        private VideoService videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {

            // Actor score = cast.GetFirstActor("score");
            // Actor food = cast.GetFirstActor("food");
            Actor player = cast.GetFirstActor("player");
            List<Actor> bullets = cast.GetGroupActors("bullet");
            List<Actor> enemies = cast.GetGroupActors("enemy");


            videoService.ClearBuffer();
            videoService.DrawActor(player);

            foreach (Actor bullet in bullets)
            {
                videoService.DrawActor(bullet);
            }
            foreach (Actor enemy in enemies)
            {
                videoService.DrawActor(enemy);
            }
            //videoService.DrawActors(/*Add the thing that needs to be drawn*/);
            // videoService.DrawActor(score);
            // videoService.DrawActor(food);
            videoService.FlushBuffer();
        }
    }
}