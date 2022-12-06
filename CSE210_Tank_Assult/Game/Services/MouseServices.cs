using Raylib_cs;
using System.Numerics;

namespace CSE210_Assult.Game.Services
{
    public class MouseServives

    {
        public void Main()
        {
            Vector2 MousePosition = Raylib.GetMousePosition();
            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT)) 
            {
                ;
            }  
        }     
    }

}