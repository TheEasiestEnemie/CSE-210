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

            velocity.X = this.pointer.X * speed;
            velocity.Y = this.pointer.Y * speed;
        }
    }
}