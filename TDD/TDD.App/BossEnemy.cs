namespace TDD.App
{
    public class BossEnemy : Enemy, IBossEnemy
    {
        public int ExtraPower()
        {
            return 42;
        }
    }
}

