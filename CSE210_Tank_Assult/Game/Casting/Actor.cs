using System;
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
        protected double velocity;
        protected double radius;

        protected Vector2 position;
        protected Circle model;

        protected Vector2 pointer;
        protected Color color = Constants.WHITE;

        public Actor() 
        {
            velocity = 0;
            radius = 10;
            position = new Vector2(0, 0);
            pointer = VectorCalculation.GetDirectionVector(position, new Vector2(1, 0));
            model = new Circle(position.X, position.Y, radius);
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
        public Point GetPosition()
        {
            return position;
        }

        /// <summary>
        /// Gets the actor's text.
        /// </summary>
        /// <returns>The text.</returns>
        public string GetText()
        {
            return text;
        }

        /// <summary>
        /// Gets the actor's current velocity.
        /// </summary>
        /// <returns>The velocity.</returns>
        public Point GetVelocity()
        {
            return velocity;
        }

        /// <summary>
        /// Moves the actor to its next position according to its velocity. Will wrap the position 
        /// from one side of the screen to the other when it reaches the maximum x and y 
        /// values.
        /// </summary>
        public virtual void MoveNext()
        {
            int x = (int)(position.X + velocity * pointer.X);
            int y = (int)(position.Y + velocity * pointer.Y);
            
            position = new Vector2(x, y);
        }

        /// <summary>
        /// Grows the snake's tail by the given number of segments.
        /// </summary>
        /// <param name="numberOfSegments">The number of segments to grow.</param>
        public virtual void GrowTail(int numberOfSegments)
        {
            
        }

        /// <summary>
        /// Sets the actor's color to the given value.
        /// </summary>
        /// <param name="color">The given color.</param>
        /// <exception cref="ArgumentException">When color is null.</exception>
        public void SetColor(Color color)
        {
            if (color == null)
            {
                throw new ArgumentException("color can't be null");
            }
            this.color = color;
        }

        /// <summary>
        /// Sets the actor's font size to the given value.
        /// </summary>
        /// <param name="fontSize">The given font size.</param>
        /// <exception cref="ArgumentException">
        /// When font size is less than or equal to zero.
        /// </exception>
        public void SetFontSize(int fontSize)
        {
            if (fontSize <= 0)
            {
                throw new ArgumentException("fontSize must be greater than zero");
            }
            this.fontSize = fontSize;
        }

        /// <summary>
        /// Sets the actor's position to the given value.
        /// </summary>
        /// <param name="position">The given position.</param>
        /// <exception cref="ArgumentException">When position is null.</exception>
        public void SetPosition(Point position)
        {
            if (position == null)
            {
                throw new ArgumentException("position can't be null");
            }
            this.position = position;
        }

        /// <summary>
        /// Sets the actor's text to the given value.
        /// </summary>
        /// <param name="text">The given text.</param>
        /// <exception cref="ArgumentException">When text is null.</exception>
        public void SetText(string text)
        {
            if (text == null)
            {
                throw new ArgumentException("text can't be null");
            }
            this.text = text;
        }

        /// <summary>
        /// Sets the actor's velocity to the given value.
        /// </summary>
        /// <param name="velocity">The given velocity.</param>
        /// <exception cref="ArgumentException">When velocity is null.</exception>
        public void SetVelocity(Point velocity)
        {
            if (velocity == null)
            {
                throw new ArgumentException("velocity can't be null");
            }
            this.velocity = velocity;
        }

    }
}