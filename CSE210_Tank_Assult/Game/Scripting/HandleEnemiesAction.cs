using CSE210_Assult.Game.Casting;
using CSE210_Assult.Game.Services;
using System.Numerics;


namespace CSE210_Assult.Game.Scripting
{
    /// <summary>
    /// <para>An input action that controls the snake.</para>
    /// <para>
    /// The responsibility of ControlActorsAction is to get the direction and move the snake's head.
    /// </para>
    /// </summary>
    public class HandleEnemiesAction : Action
    {
        private float subSpeed = 2;
        private int tick = 0;
        bool oneEnemy = false;
        public HandleEnemiesAction()
        {

        }

        public void Execute(Cast cast, Script script)
        {
            Random ran = new Random();
            PlayerTank player = (PlayerTank)cast.GetFirstActor("player");
            EnemyList enemyList = (EnemyList)cast.GetFirstActor("enemyList");
            BulletList bulletList = (BulletList)cast.GetFirstActor("bulletList");
            List<Actor> enemies = enemyList.GetList();
            tick += 1;
            if (tick % 60 == 0 && !oneEnemy)
            {
                enemyList.AddToList(new EnemyTank(ran));
                oneEnemy = false;
                for (int i = 0; i < enemies.Count; i++)
                {
                    EnemyTank enemy;
                    if (enemies[i] is EnemyTank)
                    {
                        enemy = (EnemyTank)enemies[i];
                        Bullet newBullet = enemy.Shoot();
                        bulletList.AddToList(newBullet);
                    }
                }
            }

            Vector2 playerPos = player.GetPosition();

            
            for (int i = 0; i < enemies.Count; i++)
            {
                EnemyTank enemy;
                if (enemies[i] is EnemyTank)
                {
                    enemy = (EnemyTank)enemies[i];
                    enemy.GivePlayerPosition(playerPos);
                    //enemy.MoveNext();
                }
            }
        }
    }

    
}