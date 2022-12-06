using Raylib_cs;

public class Obj
{
    public float speed
    {
        get;
        set;
    }
    public int size
    {
        get;
        set;
    }

    public float x
    {
        get;
        set;
    }
    public float y
    {
        get;
        set;
    }
    public Circle model
    {
        get;
        set;
    }
    public Obj() 
    {
        speed = 0;
        size = 10;
        x = 0;
        y = 0;
    }
}