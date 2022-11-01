public class Collectable: Obj
{
    // This creates an object capable of being collected. 
    // It doesn't know what the collectable is specifically.
    // create a rock/gem etc object to call this constructor
    public Collectable(int screenWidth) 
    { 
        Random rand = new Random();
        Obj collectable = new Obj();
        collectable.x = (float)Math.Round(rand.NextDouble() * (double)screenWidth);
        if ((collectable.x + collectable.size) > screenWidth)
        {
            collectable.x -= collectable.size;
        }

        collectable.y = 0;
    }

    public Collectable() 
    {
        Obj collectable = new Obj();
        collectable.x = 0;
        collectable.y = 0;
    }
}