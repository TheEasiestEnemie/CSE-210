using System.Numerics;
using Raylib_cs;

namespace CSE210_Assult.Game.Casting
{
    public class Bullet: Actor {
        public Bullet(Vector2 position, Vector2 pointer, double radius) {
            this.pointer = pointer;
            this.position = position;
            this.radius = 5.0;
            float speed = 5;

            position.X = (float)Math.Cos(VectorCalculation.GetAngle(new Vector2(0,0), this.pointer));
            position.Y = (float)Math.Sin(VectorCalculation.GetAngle(new Vector2(0,0), this.pointer));
            position.X = position.X * (float)radius;
            position.Y = position.Y * (float)radius;

            float pointerMagnitude = (float)VectorCalculation.GetVectorMagnitude(pointer);

            velocity.X = this.pointer.X / pointerMagnitude * speed;
            velocity.Y = this.pointer.Y / pointerMagnitude * speed;

            //Console.WriteLine("X Vector: " + velocity.X);
            //Console.WriteLine("Y Vector: " + velocity.Y);
        }
    }
}