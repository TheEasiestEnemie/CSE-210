using Raylib_cs;
using System.Numerics;

namespace CSE210_Assult.Game.Services
{
    public class MouseServices

    {
        public bool IsMouseButtonDown(string key)
        {
            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT)) 
            {
                return true;
            }  
            return false;
        }

        public static Vector2 ReturnMousePosition() {
            return Raylib.GetMousePosition();
        }
    }

}