using Raylib_cs;
using System.Numerics;

namespace CSE210_Assult.Game.Services;
{
    public class Program

    {
        public void Main()
    
        {
            // Initialization
            //--------------------------------------------------------------------------------------
            const int screenWidth = 800;
            const int screenHeight = 450;

            Raylib.InitWindow(screenWidth, screenHeight, "raylib [core] example - mouse input");

            Vector2 ballPosition = { -100.0f, -100.0f };
            Color ballColor = Color.DARKBLUE;

            Raylib.SetTargetFPS(60);               // Set our game to run at 60 frames-per-second
            //---------------------------------------------------------------------------------------

            // Main game loop
            while (!Raylib.WindowShouldClose())    // Detect window close button or ESC key
            {
                // Update
                //----------------------------------------------------------------------------------
                ballPosition = Raylib.GetMousePosition();

                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT)) 
                {
                    ballColor = Color.MAROON;
                }
                else if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_MIDDLE))
                {
                    ballColor = Color.LIME;
                }
                else if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_RIGHT)) 
                {
                    ballColor = Color.DARKBLUE;
                }
                else if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_SIDE)) 
                {
                    ballColor = Color.PURPLE;
                }
                else if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_EXTRA)) 
                {
                    ballColor = Color.YELLOW;
                }
                else if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_FORWARD)) 
                {
                    ballColor = Color.ORANGE;
                }
                else if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_BACK)) 
                {
                    ballColor = Color.BEIGE;
                }
                //----------------------------------------------------------------------------------

                // Draw
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();

                    Raylib.ClearBackground(Color.WHITE);

                    Raylib.DrawCircleV(ballPosition, 40, ballColor);

                    Raylib.DrawText("move ball with mouse and click mouse button to change color", 10, 10, 20, Color.DARKGRAY);

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------
            Raylib.CloseWindow();        // Close window and OpenGL context
            //--------------------------------------------------------------------------------------

            
        }
    }

}