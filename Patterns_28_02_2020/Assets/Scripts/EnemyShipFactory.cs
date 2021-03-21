using UnityEngine;

namespace DefaultNamespace
{
    internal class EnemyShipFactory : IArmoredEnemyFactory
    {
        public Enemy Create(Health hp, Armor armor)
        {
            var enemyShip = GameObject.Instantiate(Resources.Load<EnemyShipMark0>("Enemy/EnemyShipMark0"));
            enemyShip.DependencyInjectHealth(hp,armor);
            return enemyShip;
        }
    }
}