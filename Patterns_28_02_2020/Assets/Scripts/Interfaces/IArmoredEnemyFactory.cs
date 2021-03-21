namespace DefaultNamespace
{
    public interface IArmoredEnemyFactory
    {
        Enemy Create(Health hp, Armor armor);
        
    }
}