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
            Image image = Raylib.LoadImage("tank.png");
            //Image image = Raylib.GenImageGradientV(20, 80, Raylib_cs.Color.GRAY, Raylib_cs.Color.LIGHTGRAY);
            Raylib.ImageResize(ref image, 20, 80);
            this.texture = Raylib.LoadTextureFromImage(image);
            Raylib.UnloadImage(image);
        }

        public override void DrawImage()
        {
            Vector2 mouseVector = VectorCalculation.GetDirectionVector(position, MouseServices.ReturnMousePosition());
            //mouseVector.X += position.X;
            //mouseVector.Y += position.Y;
            Rectangle rect = new Rectangle((float)(position.X), (float)(position.Y), 2 * (float)radius, 2 * (float)radius);
            var origin = new Vector2(rect.width / 2, rect.height / 2);
            var source = new Rectangle(0, 0, rect.width, rect.height);
            double angle = VectorCalculation.GetAngle(new Vector2(1,0), mouseVector);
            angle = VectorCalculation.ConvertToDegrees(angle);
            Raylib.DrawText("Vector Angle from <1,0>: " + angle, 25, 25, 10, Raylib_cs.Color.GOLD);
            if (MouseServices.ReturnMousePosition().Y <= position.Y)
            {
                angle = -angle;
                Raylib.DrawText("FLIP IT!!!!! " + angle,25, 50, 10, Raylib_cs.Color.GOLD);
            }
            rotationAngle = angle;
            pointer = new Vector2(mouseVector.X, mouseVector.Y);
            Raylib.DrawCircle((int)position.X, (int)position.Y, (float)radius, Raylib_cs.Color.WHITE);
            Raylib.DrawTextureTiled(this.texture, source, rect, origin, (float)rotationAngle, 1, Raylib_cs.Color.GOLD);
            //Raylib.DrawLine((int)position.X, (int)position.Y, (int)mouseVector.X /* + (int)position.X */, (int)mouseVector.Y /*+ (int)position.Y*/, Raylib_cs.Color.BLUE);
        }
    }
}