using Raylib_cs;
using System.Numerics;
using CSE210_Assult.Game.Casting;
using CSE210_Assult.Game.Services;

namespace CSE210_Assult.Game.Casting
{
    public class PlayerTank: Actor {
        Texture2D texture;
        public PlayerTank() {
            position.X = (float)Constants.MAX_X / 2.0f;
            position.Y = (float)Constants.MAX_Y / 2.0f;
            var image = Raylib.LoadImage("tank.png");
            Raylib.ImageResize(ref image, 50, 50);
            texture = Raylib.LoadTextureFromImage(image);
            Raylib.UnloadImage(image);
        }

        public override void MoveNext()
        {
            int x = (int)(position.X + velocity.X);
            int y = (int)(position.Y + velocity.Y);
            if (x + radius > Constants.MAX_X || x - radius < 0) {
                if (x > 0) {
                    x -= (int)(velocity.X);
                }
                else {
                    x += (int)(velocity.X);
                }
            }
            if (y + radius > Constants.MAX_Y || y - radius < 0) {
                if (y > 0) {
                    y -= (int)(velocity.Y);
                }
                else {
                    y += (int)(velocity.Y);
                }
            }
            position = new Vector2(x, y);
        }

        public override void DrawImage()
        {
            Raylib.DrawCircle((int)position.X, (int)position.Y, (float)radius, Raylib_cs.Color.WHITE);
            Vector2 mouseVector = VectorCalculation.GetDirectionVector(position, MouseServices.ReturnMousePosition());
            double angle = VectorCalculation.GetAngle(pointer, mouseVector);
            rotationAngle += angle;
            Raylib.DrawTexture(texture, (int)position.X, (int)position.Y, Raylib_cs.Color.WHITE); //(float)rotationAngle, 1.0f, new Raylib_cs.Color());
            pointer = new Vector2(mouseVector.X, mouseVector.Y);
        }
    }
}