using System.Numerics;
using Raylib_cs;

namespace CSE210_Assult.Game.Casting
{
    public class Bullet: Actor {
        public Bullet(Vector2 position, Vector2 pointer, double radius) {
            this.pointer = pointer;
            this.position = position;
            this.radius = 5.0;
        }
    }
}