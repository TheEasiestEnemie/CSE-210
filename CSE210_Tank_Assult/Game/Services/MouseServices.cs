using Raylib_cs;
using System.Numerics;

namespace CSE210_Assult.Game.Services
{
    public class MouseServices

    {
        public bool IsMouseButtonDown(string key)
        {
            Vector2 MousePosition = Raylib.GetMousePosition();
            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT)) 
            {
                return true;
            }  
            return false;
        }     
    }

}