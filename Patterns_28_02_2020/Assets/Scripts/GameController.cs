using System.Collections.Generic;
using DefaultNamespace.UI;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private UIView _uiView;
        private Camera _camera;
        private PlayerShip _playerShip;
        private Spaceship _spaceship;
        private Bullet _bullet;
        private InputController _inputController;
        private BulletPool _bulletPool;
        private ScoreInterpretator _scoreInterpretator;
        private List<IAbility> _abilities;

        void Start()
        {
            _camera = Camera.main;
            _spaceship = FindObjectOfType<Spaceship>();
            _scoreInterpretator = new ScoreInterpretator();
            _abilities = new List<IAbility>
            {
                new Ability("Flame Ring", 111,AbilityType.Attack),
                new Ability("Force Field", 400,AbilityType.Defend),
                new Ability("Accelerator",0,AbilityType.Passive),
                new Ability("Bullet Storm", 350, AbilityType.Attack)
            };
            var moveTransform = new AccelerationMove(_spaceship.GetRigidbody(), _spaceship._speed, _spaceship._acceleration);
            var rotation = new RotationShip(_spaceship.transform);
            var shooting = new ShootingSystem(_bullet, _spaceship._leftGun, _spaceship._fireForce);
            _playerShip = new PlayerShip(moveTransform, rotation, shooting,_abilities);
            _inputController = new InputController(_playerShip, this);
            _bulletPool = new BulletPool(Resources.Load<BulletData>("Data/BulletData"));
            ServiceLocator.SetService(_bulletPool);
        }
        
        void Update()
        {
            _inputController.Execute();
        }

        public void changeScore(long value)
        {
            _uiView.SetScore(_scoreInterpretator.GetScore(value));
        }
    }
}