using Raylib_cs;

public class Rock: Collectable
{
    private int pointValue;
    new Object model;
    public Rock(int screenWidth) : base(screenWidth)
    {
        Collectable rock = new Collectable(screenWidth);
        pointValue = -1;
        model = new Rectangle((int)rock.x, (int)rock.y, rock.size, rock.size);
    }

    public void DrawRock()
    {
        // The x and y for a circle start at the center, not the top left corner
        Raylib.DrawCircle((int)x + size / 2, (int)y + size / 2, size / 2, color);
    }
}