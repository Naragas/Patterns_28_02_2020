using UnityEngine;

namespace DefaultNamespace
{
    public abstract class Enemy : MonoBehaviour
    {
        public Health Health;

        public static Asteroid CreateAsteroidEnemy(Health hp)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));
            enemy.Health = hp;
            return enemy;
            
        }
    }
}