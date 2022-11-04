using Raylib_cs;
using System.Numerics;
public class Rock: Collectable
{
    private int pointValue;
    new Object model;
    public Rock(int screenWidth) : base(screenWidth)
    {
        Collectable rock = new Collectable(screenWidth);
        pointValue = -1;
        size = 12;
        model = new Rectangle((int)x, (int)y, size, size);
    }

    override public int GetPointValue()
    {
        return pointValue;
    }

    override public void Draw() // All this function does is draw a rock. I know its a lot.
    {   
        // triangle 1
        Vector2 t1v1 = new Vector2(x + 2 * ((float)size / 3), y + (float)size);
        Vector2 t1v2 = new Vector2(x + (float)size, y + ((float)size / 2));
        Vector2 t1v3 = new Vector2(x + 2 * ((float)size / 3), y + ((float)size / 2));
        Raylib.DrawTriangle(t1v1, t1v2, t1v3, color);
        // Rectangle 1
        Raylib.DrawRectangle((int)x + 2 * (size / 3), (int)y + (size / 4), size / 3, size / 4, color);
        // triangle 2
        Vector2 t2v1 = new Vector2(x + (float)size, y + ((float)size / 4));
        Vector2 t2v2 = new Vector2(x + ((float)size / 3), y);
        Vector2 t2v3 = new Vector2(x + ((float)size / 3), y + ((float)size / 4));
        Raylib.DrawTriangle(t2v1, t2v2, t2v3, color);
        // triangle 3
        Vector2 t3v1 = new Vector2(x + ((float)size / 3), y);
        Vector2 t3v2 = new Vector2(x, y + ((float)size / 3));
        Vector2 t3v3 = new Vector2(x + ((float)size / 3), y + ((float)size / 3));
        Raylib.DrawTriangle(t3v1, t3v2, t3v3, color);
        // Rectangle 2
        Raylib.DrawRectangle((int)x, (int)y + (size / 3), size / 4, 5 * (size / 12), color);
        // triangle 4
        Vector2 t4v1 = new Vector2(x, y + 3 * ((float)size / 4));
        Vector2 t4v2 = new Vector2(x + ((float)size / 4), y + (float)size);
        Vector2 t4v3 = new Vector2(x + ((float)size / 4), y + 3 * ((float)size / 4));
        Raylib.DrawTriangle(t4v1, t4v2, t4v3, color);
        // Rectangle 3
        Raylib.DrawRectangle((int)x + (size / 4), (int)y + (size / 3), 5 * (size / 12), 2 * (size / 3), color);
        // Rectangle 4
        Raylib.DrawRectangle((int)x + (size / 3), (int)y + (size / 4), (size / 3), (size / 12), color);


        
    }
}