using Raylib_cs;
public class Player: Obj
{

    public Player(int ScreenHeight, int ScreenWidth)
    {
        
        speed = 2;
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
    public void Moveplayer()
    {
        var newModel = model;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                    newModel.x += speed;

                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                    newModel.x -= speed;
                }
        model = newModel;

        
    }
}