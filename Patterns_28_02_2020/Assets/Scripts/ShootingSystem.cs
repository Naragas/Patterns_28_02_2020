using UnityEngine;

namespace DefaultNamespace
{
    public class ShootingSystem : IShooting
    {
        private readonly Bullet _bullet;
        private readonly Transform _barrel;
        private readonly float _force;

        public ShootingSystem(Bullet bullet, Transform barrel, float force)
        {
            _bullet = bullet;
            _barrel = barrel;
            _force = force;
        }

        public void Shoot()
        {
            var bullet = GameObject.Instantiate(_bullet, _barrel.position, _barrel.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(_barrel.up * _force);
        }
    }
}