using Raylib_cs;



static class Greed
{
    public static void Main()
    {
          
        var ScreenHeight = 800;
        var ScreenWidth = 1000;
        Player player = new Player(ScreenHeight, ScreenWidth);
        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);
            player.drawplayer(player, player.model);
            player.Moveplayer();

            Raylib.EndDrawing();
        }
        
        Raylib.CloseWindow();
    }
}