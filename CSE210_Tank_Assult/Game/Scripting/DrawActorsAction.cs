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

        HandleCollisionsAction checkGameStatus;
        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService, Script script)
        {
            this.videoService = videoService;
            List<Action> updateActions = script.GetActions("update");
            foreach (Action action in updateActions)
            {
                Console.WriteLine("Searching for Collision Action...");
                if (action is HandleCollisionsAction)
                {
                    Console.WriteLine("Collision Action Found!");
                    checkGameStatus = (HandleCollisionsAction)action;
                }
            }
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            // Actor score = cast.GetFirstActor("score");
            // Actor food = cast.GetFirstActor("food");
            Actor player = cast.GetFirstActor("player");
            BulletList bulletList = (BulletList)cast.GetFirstActor("bulletList");
            EnemyList enemyList = (EnemyList)cast.GetFirstActor("enemyList");
            List<Actor> bullets = bulletList.GetList();
            List<Actor> enemies = enemyList.GetList();


            videoService.ClearBuffer();
            videoService.DrawActor(player);

            foreach (Actor bullet in bullets)
            {
                //Console.WriteLine("Atempting to draw a bullet...");
                videoService.DrawActor(bullet);
            }
            foreach (Actor enemy in enemies)
            {
                //Console.WriteLine("Atempting to draw a enemy...");
                videoService.DrawActor(enemy);
            }
            // videoService.DrawActor(score);
            // videoService.DrawActor(food);
            if (checkGameStatus.GameStatus())
            {
                videoService.DrawGameOver();
            }
            videoService.FlushBuffer();
        }
    }
}