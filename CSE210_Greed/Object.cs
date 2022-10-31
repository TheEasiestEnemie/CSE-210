using Raylib_cs;

namespace Greed{

    abstract public class Object 
    {
        
        public abstract int speed  
        {  
            get;  
            set;  
        }

        public abstract int size
        {
            get;
            set;
        }

        public abstract Color color
        {
            get;
            set;
        }

        public abstract float x
        {
            get;
            set;
        }

        public abstract float y
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
}