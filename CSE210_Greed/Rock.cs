using Raylib_cs;

public class Rock: Collectable
{
    private int pointValue;

    public Rock(int screenWidth)
    {
        Collectable rock = new Collectable(screenWidth);
        rock.model = new Rectangle((int)rock.x, (int)rock.y, rock.size, rock.size);
    }
}