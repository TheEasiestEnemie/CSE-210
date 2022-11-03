 public class Collectable: Obj
{
    protected float vspeed;
    protected float hspeed;
    protected float TOPVSPEED = 5; // How fast an object can go

    // This creates an object capable of being collected. 
    // It doesn't know what the collectable is specifically.
    // create a rock/gem etc object to call this constructor
    public Collectable(int screenWidth)
    { 
        Random rand = new Random();
        x = (float)Math.Round(rand.NextDouble() * (double)screenWidth);
        if ((x + size) > screenWidth)
        {
            x -= size;
        }

        y = 0;

        hspeed = 0; // Collectables don't need to move left or right
        vspeed = (float)rand.NextDouble() * TOPVSPEED + 3.0f; // the 3.0f is the minimum speed

    }

    public float MoveVertical(bool down) // moves a collectable up or down
    {
        if (down)
        {
            y += vspeed;
        }
        else
        {
            y -= vspeed;
        }
        return y;
    }

    public float MoveHorizontal(bool right) // moves a collectable left or right
    {
        if (right)
        {
            x += hspeed;
        }
        else
        {
            x -= hspeed;
        }
        return x;
    }

    public bool IsOffScreen(int screenWidth, int screenHeight) // checks if an object is off screen
    {
        if ((x + size > screenWidth) || (y + size > screenHeight))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}