using System.Numerics;
using Raylib_cs;
using CSE210_Assult.Game.Services;

namespace CSE210_Assult.Game.Casting
{
    public class Bullet: Actor {
        string source = "enemy";
        public Bullet(Vector2 position, Vector2 pointer, double radius, string shotBy) {
            this.pointer = pointer;
            this.position = position;
            this.radius = 3.0;
            float speed = 5;
            color = new Color(255, 0, 0);
            if (shotBy.Equals("player"))
            {
                source = "player";
                color = new Color(255, 255, 255);
                
            }

            //float bulletAngleX = (float)Math.Cos(VectorCalculation.GetAngle(new Vector2(1,0), this.pointer));
            //float bulletAngleY = (float)Math.Sin(VectorCalculation.GetAngle(new Vector2(1,0), this.pointer));
            /*if (MouseServices.ReturnMousePosition().Y <= position.Y)
            {
                bulletAngleX = -bulletAngleX;
                bulletAngleY = -bulletAngleY;
            }
            this.position.X = (float)radius * bulletAngleX + position.X;
            this.position.Y = (float)radius * bulletAngleY + position.Y;*/
            //this.position.X = position.X * (float)radius;
            //this.position.Y = position.Y * (float)radius;

            float pointerMagnitude = (float)VectorCalculation.GetVectorMagnitude(pointer);

            velocity.X = this.pointer.X / pointerMagnitude * speed;
            velocity.Y = this.pointer.Y / pointerMagnitude * speed;

            //Console.WriteLine("X Vector: " + velocity.X);
            //Console.WriteLine("Y Vector: " + velocity.Y);
        }

        public string GetSource()
        {
            return source;
        }
    }
}