using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerShip: IMove,IRotation,IShooting
    {
        private readonly IMove _moveSystem;
        private readonly IRotation _rotationSystem;
        private readonly ShootingSystem _shootingSystem;

        public float Speed => _moveSystem.Speed;

        public PlayerShip(IMove moveSystem, IRotation rotationSystem, ShootingSystem shootingSystem)
        {
            _moveSystem = moveSystem;
            _rotationSystem = rotationSystem;
            _shootingSystem = shootingSystem;
        }
        public void Move(float horizontal, float vertical)
        {
            _moveSystem.Move(horizontal,vertical);
        }

        public void Rotation(Vector3 direction)
        {
            _rotationSystem.Rotation(direction);
        }

        public void Shoot()
        {
            _shootingSystem.Shoot();
        }
    }
}