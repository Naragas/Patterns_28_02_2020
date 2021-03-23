using UnityEngine;

namespace DefaultNamespace
{
    public class GameController : MonoBehaviour
    {
        private Camera _camera;
        private PlayerShip _playerShip;
        private Spaceship _spaceship;
        private Bullet _bullet;
        private InputController _inputController;
        private BulletPool _bulletPool;

        void Start()
        {
            _camera = Camera.main;
            _spaceship = FindObjectOfType<Spaceship>();
            var moveTransform = new AccelerationMove(_spaceship.GetRigidbody(), _spaceship._speed, _spaceship._acceleration);
            var rotation = new RotationShip(_spaceship.transform);
            var shooting = new ShootingSystem(_bullet, _spaceship._leftGun, _spaceship._fireForce);
            _playerShip = new PlayerShip(moveTransform, rotation, shooting);
            _inputController = new InputController(_playerShip);
            _bulletPool = new BulletPool(Resources.Load<BulletData>("Data/BulletData"));
            ServiceLocator.SetService(_bulletPool);
        }

        void Update()
        {
            _inputController.Execute();
        }
    }
}