using Raylib_cs;
public class Player: Obj
{

    public Player(int ScreenHeight, int ScreenWidth)
    {
        
        speed = 10;
        size = 15;
        color = Raylib_cs.Color.WHITE;
        x = ScreenWidth / 2;
        y = ScreenHeight - size;
        model = new Rectangle(x, y, size, size);

    }

    public void drawplayer(Player player, Rectangle playerModel)
    {
        Raylib.DrawRectangleRec(model, color);
    }
    public void Moveplayer(int screenWidth)
    {
        var newModel = model;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) && (screenWidth > newModel.x + size) ) 
        {

            newModel.x += speed;

        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) && newModel.x > 0) 
        {
            newModel.x -= speed;
        }
        if (x > screenWidth - size)
        {
            newModel.x = screenWidth - size;
        }
        model = newModel;
        
        
    }
}