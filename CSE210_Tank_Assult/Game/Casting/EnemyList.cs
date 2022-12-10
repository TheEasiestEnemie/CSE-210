namespace CSE210_Assult.Game.Casting
{
    public class EnemyList: Actor
    {
        List<Actor> enemyList;
        public EnemyList()
        {
            enemyList = new List<Actor>();
        }

        public List<Actor> GetList()
        {
            return enemyList;
        }

        public void AddToList(Actor enemy)
        {
            enemyList.Add(enemy);
            Console.WriteLine("Successfully added an enemy!");
        }

        public void RemoveFromList(int index) {
            enemyList.RemoveAt(index);
        }
    }   
}