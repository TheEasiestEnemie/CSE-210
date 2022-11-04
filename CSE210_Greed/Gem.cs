using Raylib_cs;

public class Gem: Collectable
{
    private int pointValue;
    new Object model;
    public Gem(int screenWidth) : base(screenWidth)
    {
        Collectable gem = new Collectable(screenWidth);
        pointValue = 1;
        size = 12;
        model = new Rectangle((int)x, (int)y, size, size);
    }

    override public int GetPointValue()
    {
        return pointValue;
    }
    override public void Draw() // Draws a 5 point star (not filled in)
    {
        Raylib.DrawLine((int)x, (int)y + size, (int)x + (size / 2), (int)y, color);
        Raylib.DrawLine((int)x + (size / 2), (int)y, (int)x + size, (int)y + size, color);
        Raylib.DrawLine((int)x + size, (int)y + size, (int)x, (int)y + (size / 3),  color);
        Raylib.DrawLine((int)x, (int)y + (size / 3), (int)x + size, (int)y + (size / 3), color);
        Raylib.DrawLine((int)x + size, (int)y + (size / 3), (int)x, (int)y + size, color);
    }
}