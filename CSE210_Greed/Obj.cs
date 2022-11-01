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
    public Color color
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
    public static Color GetRandomColor()
    {
        Random random = new Random();
        int r = (int)Math.Round((random.NextDouble() * 255.0));
        int g = (int)Math.Round((random.NextDouble() * 255.0));
        int b = (int)Math.Round((random.NextDouble() * 255.0));
        Color randColor = new Color(r, g, b, 255);
        return randColor;
    }
}