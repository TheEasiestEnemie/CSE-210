using Raylib_cs;



static class Greed
{
    public static void Main()
    {
          
        var screenHeight = 800;
        var screenWidth = 1000;
        Player player = new Player(screenHeight, screenWidth);
        Raylib.InitWindow(screenWidth, screenHeight, "Greed");
        Raylib.SetTargetFPS(60);

        ////////////////////// Jack's Segment of code //////////////////////
        int NUMOFCOLLECTABLES = 2;
        List<Collectable> collectablesOnScreen = new List<Collectable>();
        List<int> itemsToDelete = new List<int>();


        int tick = 0;
        /////////////////////////////// End ////////////////////////////////

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);
            player.drawplayer(player, player.model);
            player.Moveplayer();

            ////////////////////////// Jacks portion of Code for the game ///////////////////////////

            if (tick % 20 == 0) // Adds a random collectable every time this statement runs
            {

                Random rand = new Random();
                int choice = rand.Next(0, NUMOFCOLLECTABLES);
                switch (choice)
                {
                    case 0: 
                    {
                        var rock = new Rock(screenWidth); 
                        collectablesOnScreen.Add(rock);
                        break;
                    }
                    case 1: 
                    {
                        var gem = new Gem(screenWidth); 
                        collectablesOnScreen.Add(gem);
                        break;
                    }
                }
            }
            for (int i = 0; i < collectablesOnScreen.Count(); i++) //Makes the falling animation
            {
                collectablesOnScreen[i].Draw();
                collectablesOnScreen[i].MoveVertical(true); // write the collision check here when you get to that
                if (collectablesOnScreen[i].IsOffScreen(screenWidth, screenHeight)) // checks if object is offscreen
                {
                    itemsToDelete.Add(i); // removes said object from the list when it goes out of bounds
                }
            }
            for (int i = 0; i < itemsToDelete.Count(); i++) // deletes items out of bounds
            {
                collectablesOnScreen.RemoveAt(itemsToDelete[i]); // deletes the obj at the index number stored in itemstodelete
            }   
            itemsToDelete.RemoveRange(0, itemsToDelete.Count()); // wipes the list so it doesnt delete everything
            ////////////////////////////////////////////// END ////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////
            //////////////////// ADD SCORE BOARD HERE /////////////////////
            ///////////////////////////////////////////////////////////////

            Raylib.EndDrawing();

            tick++;
            if (tick >= 60) // resets ticks after every second
            {
                tick = 0;
            }
        }

        Raylib.CloseWindow();
    }
}
