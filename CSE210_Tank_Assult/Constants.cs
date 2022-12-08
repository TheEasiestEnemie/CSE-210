using CSE210_Assult.Game.Casting;
using System.Numerics;

namespace CSE210_Assult.Game
{
    /// <summary>
    /// <para>A tasty item that snakes like to eat.</para>
    /// <para>
    /// The responsibility of Food is to select a random position and points that it's worth.
    /// </para>
    /// </summary>
    public class Constants
    {
        public static int COLUMNS = 40;
        public static int ROWS = 20;
        public static int CELL_SIZE = 15;
        public static int MAX_X = 1800;
        public static int MAX_Y = 1000;
        public static int FRAME_RATE = 60;
        public static int FONT_SIZE = 15;
        public static string CAPTION = "Snake";
        public static int SNAKE_LENGTH = 8;
        public static Vector2 TAIL_GROWTH_RATE = new Vector2(-100, 5); // these are odds of growing a new tail segment. if the number is negative, it doesn't grow a new segment.
        public static Color RED = new Color(255, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color YELLOW = new Color(255, 255, 0);
        public static Color GREEN = new Color(0, 255, 0);

    }
}

