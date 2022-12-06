using Raylib_cs;
using System.Numerics;
using CSE210_Assult.Game.Casting;

namespace CSE210_Assult.Game.Casting
{
    public class PlayerTank: Actor {
        Texture2D texture;
        PlayerTank() {
            position.X = (float)Constants.MAX_X / 2.0f;
            position.Y = (float)Constants.MAX_Y / 2.0f;
            var image = Raylib.LoadImage("../Images/tank.png");
            Raylib.ImageResize(ref image, 50, 50);
            this.texture = Raylib.LoadTextureFromImage(image);
            Raylib.UnloadImage(image);
        }

        public void Draw() {

        }

        public override void MoveNext()
        {
            int x = (int)(position.X + velocity * pointer.X);
            int y = (int)(position.Y + velocity * pointer.Y);
            if (x + radius > Constants.MAX_X || x - radius < 0) {
                if (x > 0) {
                    x -= (int)(velocity * pointer.X);
                }
                else {
                    x += (int)(velocity * pointer.X);
                }
            }
            if (y + radius > Constants.MAX_Y || y - radius < 0) {
                if (y > 0) {
                    y -= (int)(velocity * pointer.Y);
                }
                else {
                    y += (int)(velocity * pointer.Y);
                }
            }
            position = new Vector2(x, y);
        }
    }
}