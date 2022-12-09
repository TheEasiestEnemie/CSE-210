using System;
using Raylib_cs;
using System.Numerics;


namespace CSE210_Assult.Game.Casting
{
    /// <summary>
    /// <para>A thing that participates in the game.</para>
    /// <para>
    /// The responsibility of Actor is to keep track of its appearance, position and velocity in 2d 
    /// space.
    /// </para>
    /// </summary>
    public class Actor
    {
        protected Vector2 velocity;
        protected double radius;
        protected double rotationAngle; 
        protected Vector2 position;
        protected Vector2 pointer; //determines the rotation of the actor plus where it shoots a bullet
        protected Color color = Constants.WHITE;
        protected string name;

        public Actor() 
        {
            name = "";
            velocity = new Vector2(0, 0);
            radius = 10;
            position = new Vector2(50, 50);
            pointer = VectorCalculation.GetDirectionVector(position, new Vector2(1, 0));
            rotationAngle = 0;
        }


        /// <summary>
        /// Gets the actor's color.
        /// </summary>
        /// <returns>The color.</returns>
        public Color GetColor()
        {
            return color;
        }

        /// <summary>
        /// Gets the actor's position.
        /// </summary>
        /// <returns>The position.</returns>
        public Vector2 GetPosition()
        {
            return position;
        }

        /// <summary>
        /// Gets the actor's current velocity.
        /// </summary>
        /// <returns>The velocity.</returns>
        public Vector2 GetVelocity()
        {
            return velocity;
        }

        public double GetRadius()
        {
            return radius;
        }

        /// <summary>
        /// Moves the actor to its next position according to its velocity. Will wrap the position 
        /// from one side of the screen to the other when it reaches the maximum x and y 
        /// values.
        /// </summary>
        public virtual void MoveNext()
        {
            int x = (int)(position.X + velocity.X);
            int y = (int)(position.Y + velocity.Y);
            
            position = new Vector2(x, y);
        }

        public virtual void DrawImage()
        {
            Raylib.DrawCircle((int)position.X, (int)position.Y, (float)radius, new Raylib_cs.Color(color.GetRed(), color.GetGreen(), color.GetBlue(), color.GetAlpha()));
        }

        public virtual Bullet Shoot()
        {
            Bullet bullet = new Bullet(position, pointer, radius, name);
            //Console.WriteLine("BANG!");
            return bullet;
        }

        /// <summary>
        /// Sets the actor's position to the given value.
        /// </summary>
        /// <param name="position">The given position.</param>
        /// <exception cref="ArgumentException">When position is null.</exception>
        public void SetPosition(Vector2 position)
        {
            if (position == null)
            {
                throw new ArgumentException("position can't be null");
            }
            this.position = position;
        }

        /// <summary>
        /// Sets the actor's velocity to the given value.
        /// </summary>
        /// <param name="velocity">The given velocity.</param>
        /// <exception cref="ArgumentException">When velocity is null.</exception>
        public void SetVelocity(Vector2 velocity)
        {
            if (velocity == null)
            {
                throw new ArgumentException("velocity can't be null");
            }
            this.velocity = velocity;
        }

    }
}