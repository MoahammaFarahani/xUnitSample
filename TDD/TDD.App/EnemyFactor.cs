namespace TDD.App
{
    public class EnemyFactor : IEnemyFactor
    {
        public  object  Create(bool isBoos)
        {
            if (isBoos)
                return new BossEnemy();
            return new NormalEnemy();
        }
    }  
}

