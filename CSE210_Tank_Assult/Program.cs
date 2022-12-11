using CSE210_Assult.Game.Casting;
using CSE210_Assult.Game.Directing;
using CSE210_Assult.Game.Scripting;
using CSE210_Assult.Game.Services;
using CSE210_Assult.Game;


namespace CSE210_Assult
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();
            Script script = new Script();

            // create the services
            KeyboardService keyboardService = new KeyboardService();
            MouseServices mouseServices = new MouseServices();
            VideoService videoService = new VideoService(false);
            videoService.OpenWindow();
            
            PlayerTank player = new PlayerTank(script);
            BulletList bulletList = new BulletList();
            EnemyList enemyList = new EnemyList();
            cast.AddActor("player", player);
            cast.AddActor("bulletList", bulletList);
            cast.AddActor("enemyList", enemyList);
            // create the script
            script.AddAction("input", new ControlActorsAction(keyboardService, mouseServices));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleEnemiesAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService, script));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}