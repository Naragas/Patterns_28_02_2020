using UnityEngine;

namespace DefaultNamespace
{
    public class GameStarter : MonoBehaviour
    {
        private void Start()
        {
            Enemy.CreateAsteroidEnemy(new Health(100.0f, 100.0f));
            
            IEnemyFactory factory = new AsteroidFactory();
            factory.Create(new Health(100.0f, 100.0f));
            IArmoredEnemyFactory armoredEnemyFactory = new EnemyShipFactory();
            armoredEnemyFactory.Create(new Health(100.0f, 100.0f), new Armor(50.0f, 50.0f));
        }
        
    }
}