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
            radius = 50;
            var image = Raylib.LoadImage("tank.png");
            Raylib.ImageResize(ref image, 100, 100);
            this.texture = Raylib.LoadTextureFromImage(image);
            Raylib.UnloadImage(image);
        }

        public override void DrawImage()
        {
            //Raylib.DrawCircle((int)position.X, (int)position.Y, (float)radius, Raylib_cs.Color.WHITE);
            Vector2 mouseVector = VectorCalculation.GetDirectionVector(position, MouseServices.ReturnMousePosition());
            Rectangle rect = new Rectangle((float)(position.X), (float)(position.Y), 2 * (float)radius, 2 * (float)radius);
            var origin = new Vector2(rect.width / 2, rect.height / 2);
            var source = new Rectangle(0, 0, rect.width, rect.height);
            double angle = VectorCalculation.GetAngle(pointer, mouseVector);
            rotationAngle += angle;
            pointer = new Vector2(mouseVector.X, mouseVector.Y);
            Raylib.DrawTextureTiled(this.texture, source, rect, origin, (float)rotationAngle, 1.0F, Raylib_cs.Color.WHITE);
        }
    }
}