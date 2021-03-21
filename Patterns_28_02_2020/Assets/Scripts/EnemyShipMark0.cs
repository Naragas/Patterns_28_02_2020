namespace DefaultNamespace
{
    public sealed class EnemyShipMark0 : ArmoredEnemy
    {
        public void DependencyInjectHealth(Health hp, Armor armor)
        {
            Health = hp;
            Armor = armor;
        }
    }
}