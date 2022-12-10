
namespace CSE210_Assult.Game.Casting
{

    public class BulletList: Actor
    {
        List<Actor> bulletList; 
        public BulletList()
        {
            bulletList = new List<Actor>();
        }

        public List<Actor> GetList()
        {
            return bulletList;
        }

        public void AddToList(Actor bullet)
        {
            bulletList.Add(bullet);
            //Console.WriteLine("Successfully added a bullet!");
        }

        public void RemoveFromList(int index) {
            bulletList.RemoveAt(index);
        }
    }
}