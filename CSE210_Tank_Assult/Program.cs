﻿using CSE210_Assult.Game.Casting;
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
            cast.AddActor();

            // create the services
            KeyboardService keyboardService = new KeyboardService();
            MouseServives mouseServices = new MouseServives();
            VideoService videoService = new VideoService(false);
           
            // create the script
            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService, mouseServices));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}