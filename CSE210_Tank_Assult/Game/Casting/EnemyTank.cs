using Raylib_cs;
using System.Numerics;
using CSE210_Assult.Game.Casting;
using CSE210_Assult.Game.Services;




namespace CSE210_Assult.Game.Casting
{
    public class EnemyTank: Actor 
    {
        Texture2D texture;
        Vector2 playerPosition;
        float speed;
        public EnemyTank() {
            speed = 1;
            Random ran = new Random();
            name = "enemy";
            float change = ran.Next(1,5);
            if (change == 1)
            {
                position.X = ran.Next(0, Constants.MAX_X);
                position.Y = 0 - 2 * (float)radius;
            }
            else if (change == 2)
            {
                position.Y = ran.Next(0, Constants.MAX_Y);
                position.X = 0 + 2 * (float)radius;
            }
            else if (change == 3)
            {
                position.X = ran.Next(0, Constants.MAX_X);
                position.Y = 0 + 2 * (float)radius;
            }
            else if (change == 4)
            {
                position.Y = ran.Next(0, Constants.MAX_Y);
                position.X = 0 - 2 * (float)radius;
            }


            position.X = (float)Constants.MAX_X;
            position.Y = (float)Constants.MAX_Y;
            var image = Raylib.LoadImage("tank.png");
            //Raylib.ImageResize(ref image, 50, 50);
            this.texture = Raylib.LoadTextureFromImage(image);
            Raylib.UnloadImage(image);
        }

        public void GivePlayerPosition(Vector2 playerPos)
        {
            playerPosition = playerPos;
        }

        public void Move()
        {
            float pointerMagnitude = (float)VectorCalculation.GetVectorMagnitude(pointer);

            velocity.X = this.pointer.X / pointerMagnitude * speed;
            velocity.Y = this.pointer.Y / pointerMagnitude * speed;

            this.MoveNext();
        }

        public override void DrawImage()
        {
            //////////// COPIED FROM PLAYERTANK /////////////
            Vector2 playerVector = VectorCalculation.GetDirectionVector(position, playerPosition);
            //mouseVector.X += position.X;
            //mouseVector.Y += position.Y;
            Rectangle rect = new Rectangle((float)(position.X), (float)(position.Y), 2 * (float)radius, 2 * (float)radius + 20);
            var origin = new Vector2(rect.width / 2, rect.height / 2 + 10);
            var source = new Rectangle(0, 0, rect.width, rect.height);
            double angle = VectorCalculation.GetAngle(new Vector2(0,-1), playerVector);
            angle = VectorCalculation.ConvertToDegrees(angle);
            //Raylib.DrawText("Vector Angle from <1,0>: " + angle, 25, 25, 10, Raylib_cs.Color.GOLD);
            if (MouseServices.ReturnMousePosition().X <= position.X)
            {
                angle = -angle;
                //Raylib.DrawText("FLIP IT!!!!! " + angle,25, 50, 10, Raylib_cs.Color.GOLD);
            }
            rotationAngle = angle;
            pointer = new Vector2(playerVector.X, playerVector.Y);
            //Raylib.DrawCircle((int)position.X, (int)position.Y, (float)radius, Raylib_cs.Color.WHITE);
            Raylib.DrawTextureTiled(this.texture, source, rect, origin, (float)rotationAngle, 1, Raylib_cs.Color.RED);
            //Raylib.DrawLine((int)position.X, (int)position.Y, (int)playerVector.X /* + (int)position.X */, (int)playerVector.Y /*+ (int)position.Y*/, Raylib_cs.Color.BLUE);
        }
    }
}