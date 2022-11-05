using Raylib_cs;
using System.Numerics;

public class LargeGem: Collectable {
    public LargeGem(int screenWidth) : base(screenWidth)
    {
        pointValue = 5;
        size = 18;
        model = new Rectangle((int)x, (int)y, size, size);
    }

    public override void Draw() // Draws a bomb shape
    {
        int ix = (int)x;
        int iy = (int)y;
        float size6 = (float)size / 5.0f;
        float size4 = (float)size / 4.0f;
        float size3 = (float)size / 3.0f;
        float size2 = (float)size / 2.0f;

        // triangle 1
        Vector2 t1v1 = new Vector2(x + size6 + size4, y + size4);
        Vector2 t1v2 = new Vector2(x + size4, y + size2);
        Vector2 t1v3 = new Vector2(x + size6 + size4, y + size2);
        Raylib.DrawTriangle(t1v1, t1v2, t1v3, color);
        // triangle 2
        Vector2 t2v1 = new Vector2(x + size4, y + size2);
        Vector2 t2v2 = new Vector2(x + size6 + size4, y + (3 * size4));
        Vector2 t2v3 = new Vector2(x + size6 + size4, y + size2);
        Raylib.DrawTriangle(t2v1, t2v2, t2v3, color);
        // Rectangle 1
        Raylib.DrawRectangle((int)(x + size6 + size4), (int)(y + size4), (int)size6, (int)size2, color);
        // triangle 3
        Vector2 t3v1 = new Vector2(x + size4 + size3, y + (3 * size4));
        Vector2 t3v2 = new Vector2(x + (3 * size4), y + size2);
        Vector2 t3v3 = new Vector2(x + size4 + size3, y + size2);
        Raylib.DrawTriangle(t3v1, t3v2, t3v3, color);
        // triangle 4
        Vector2 t4v1 = new Vector2(x + size4 + size3, y + size2);
        Vector2 t4v2 = new Vector2(x + (3 * size4), y + size2);
        Vector2 t4v3 = new Vector2(x + size4 + size3, y + size4);
        Raylib.DrawTriangle(t4v1, t4v2, t4v3, color);

        // Begin Lines 1-12

        Raylib.DrawLine(ix + (int)(2 * size3), iy, ix + (int)size3, iy, color); // Line 1
        Raylib.DrawLine(ix + (int)size3, iy, ix, iy + (int)size2, color); // Line 2
        Raylib.DrawLine(ix, iy + (int)size2, ix + (int)size3, iy + size, color); // Line 3
        Raylib.DrawLine(ix + (int)size3, iy + size, ix + (int)(2 * size3), iy + size, color); // Line 4
        Raylib.DrawLine(ix + (int)(2 * size3), iy + size, ix + size, iy + (int)size2, color); // Line 5
        Raylib.DrawLine(ix + size, iy + (int)size2, ix + (int)(2 * size3), iy, color); // Line 6

        Raylib.DrawLine(ix + (int)(2 * size3), iy, ix + (int)(size4 + size3), iy + (int)size4, color); // Line 7
        Raylib.DrawLine(ix + (int)(size3), iy, ix + (int)(size6 + size4), iy + (int)size4, color); // Line 8
        Raylib.DrawLine(ix, iy + (int)size2, ix + (int)size4, iy + (int)size2, color); // Line 9
        Raylib.DrawLine(ix + (int)size3, iy + size, ix + (int)(size4 + size6), iy + (int)(3 * size4), color); // Line 10
        Raylib.DrawLine(ix + (int)(2 * size3), iy + size, ix + (int)(size4 + size3), iy + (int)(3 * size4), color); // Line 11
        Raylib.DrawLine(ix + (int)(3 * size4), iy + (int)size2, ix + size, iy + (int)size2, color); // Line 12
    }
}