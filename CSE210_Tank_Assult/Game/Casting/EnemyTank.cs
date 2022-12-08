using Raylib_cs;
using System.Numerics;
using CSE210_Assult.Game.Casting;
using CSE210_Assult.Game.Services;




namespace CSE210_Assult.Game.Casting
{
    public class EnemyTank: Actor 
    {
        Texture2D texture;
        public EnemyTank() {
            Random ran = new Random();
            float change = ran.Next(1,5);
            if (change == 1)
            {
                position.X = ran.Next(0, Constants.MAX_X);
                position.Y = 0 - 2 * (float)radius;
            }
            else if (change == 2)
            {
                position.Y = ran.Next(0, Constants.MAX_X);
                position.X = 0 + 2 * (float)radius;
            }
            else if (change == 3)
            {
                position.X = ran.Next(0, Constants.MAX_X);
                position.Y = 0 + 2 * (float)radius;
            }
            else if (change == 4)
            {
                position.Y = ran.Next(0, Constants.MAX_X);
                position.X = 0 - 2 * (float)radius;
            }


            position.X = (float)Constants.MAX_X;
            position.Y = (float)Constants.MAX_Y;
            var image = Raylib.LoadImage("Tank.png");
            //Raylib.ImageResize(ref image, 50, 50);
            this.texture = Raylib.LoadTextureFromImage(image);
            Raylib.UnloadImage(image);
        }
    }
}