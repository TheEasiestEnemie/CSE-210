using Raylib_cs;


static class Greed
{
    public static void Main()
    {
        var ScreenHeight = 800;
        var ScreenWidth = 1000;
        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);


            Raylib.EndDrawing();
        }
        
        Raylib.CloseWindow();
    }
}