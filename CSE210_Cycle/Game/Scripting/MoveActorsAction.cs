using System.Collections.Generic;
using Unit05.Game.Casting;
using System;
using Unit05.Game;


namespace Unit05.Game.Scripting
{
    // TODO: Implement the MoveActorsAction class here

    // 1) Add the class declaration. Use the following class comment. Make sure you
    //    inherit from the Action class.

    /// <summary>
    /// <para>An update action that moves all the actors.</para>
    /// <para>
    /// The responsibility of MoveActorsAction is to move all the actors.
    /// </para>
    /// </summary>

    public class MoveActorsAction : Action
    {


    // 2) Create the class constructor. Use the following method comment.

    /// <summary>
    /// Constructs a new instance of MoveActorsAction.
    /// </summary>

        public MoveActorsAction()
        {
        }
        
    // 3) Override the Execute(Cast cast, Script script) method. Use the following 
    //    method comment. You custom implementation should do the following:
    //    a) get all the actors from the cast
    //    b) loop through all the actors
    //    c) call the MoveNext() method on each actor.

        public void Execute(Cast cast, Script script)
        {
            List<Actor> actors = cast.GetAllActors();
            int noChance = (int)Constants.TAIL_GROWTH_RATE.X;
            int yesChance = (int)Constants.TAIL_GROWTH_RATE.Y;
            foreach (Actor actor in actors)
            {
                if (actor is Snake) 
                {
                    Random r = new Random();
                    int determiner = r.Next(noChance, yesChance);

                    if (determiner >= 0)
                    {
                        actor.GrowTail(1);
                    }
                }
                actor.MoveNext();
            }

        }
    }
}