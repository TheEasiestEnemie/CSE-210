using Raylib_cs;

public class Bomb: Collectable {
    public Bomb(int screenWidth) : base(screenWidth)
    {
        pointValue = -5;
        size = 12;
        model = new Rectangle((int)x, (int)y, size, size);
    }

    public override void Draw() // Draws a bomb shape
    {
        int ix = (int)x;
        int iy = (int)y;
        int centerX = ix + (size / 2);
        int centerY = iy + (size / 2);
        Raylib.DrawLine(centerX, centerY, ix + 5 * (size / 4), iy - (size / 4), color); //Draws the fuse
        Raylib.DrawCircle(centerX, centerY, size / 2, color);
    }

}