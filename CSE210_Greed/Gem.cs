using Raylib_cs;

public class Gem: Collectable
{
    private int pointValue;
    new Object model;
    public Gem(int screenWidth) : base(screenWidth)
    {
        Collectable gem = new Collectable(screenWidth);
        pointValue = -1;
        model = new Rectangle((int)gem.x, (int)gem.y, gem.size, gem.size);
    }

    public void DrawGem(Object model)
    {
        // The x and y for a circle start at the center, not the top left corner
        Raylib.DrawCircle((int)x + size / 2, (int)y + size / 2, size / 2, color);
    }
}