using Raylib_cs;

namespace Greed{

    abstract public class Object 
    {
        
        public abstract int velocity  
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
            Random RandomInt = new Random();
            double dr = Math.Round((RandomInt.NextDouble() * 255.0));
            double dg = Math.Round((RandomInt.NextDouble() * 255.0));
            double db = Math.Round((RandomInt.NextDouble() * 255.0));
            int r = Decimal.ToInt32(dr);
            int g = Decimal.ToInt32(dg);
            int b = Decimal.ToInt32(db);

            Color randColor = new Color(r, g, b, 255);
            return randColor;
        }
    }
}