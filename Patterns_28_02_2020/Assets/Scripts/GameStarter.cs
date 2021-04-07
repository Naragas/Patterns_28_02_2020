using DefaultNamespace.UI;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameStarter : MonoBehaviour
    {
        [SerializeField] private UIView _uiView;
        private void Start()
        {
            ;
            _uiView.Add(Enemy.CreateAsteroidEnemy(new Health(100.0f, 100.0f)));
            
            IEnemyFactory factory = new AsteroidFactory();
            factory.Create(new Health(100.0f, 100.0f));
            IArmoredEnemyFactory armoredEnemyFactory = new EnemyShipFactory();
            armoredEnemyFactory.Create(new Health(100.0f, 100.0f), new Armor(50.0f, 50.0f));
        }
        
    }
}