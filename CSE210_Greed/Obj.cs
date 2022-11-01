using Raylib_cs;

abstract public class Obj
{
    float speed;
    int size;
    Color color;
    float x;
    float y;
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