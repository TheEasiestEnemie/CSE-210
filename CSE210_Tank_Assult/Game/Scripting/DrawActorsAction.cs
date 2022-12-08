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
            foreach (Actor bullet in bullets) 
            {
                bullet.DrawImage();
            }
            videoService.ClearBuffer();
            //videoService.DrawActors(/*Add the thing that needs to be drawn*/);
            videoService.DrawActor(player);
            // videoService.DrawActor(score);
            // videoService.DrawActor(food);
            videoService.FlushBuffer();
        }
    }
}