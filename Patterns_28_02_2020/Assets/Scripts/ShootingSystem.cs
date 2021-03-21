using UnityEngine;

namespace DefaultNamespace
{
    public class ShootingSystem : IShooting
    {
        private readonly Bullet _bullet;
        private readonly Transform _barrel;
        private readonly float _force;
        private BulletPool _bulletPool;
        

        public ShootingSystem(Bullet bullet, Transform barrel, float force)
        {
            _bullet = bullet;
            _barrel = barrel;
            _force = force;
        }

        public void Shoot()
        {
            if (_bulletPool == null)
            {
                _bulletPool = new BulletPool(Resources.Load<BulletData>("Data/BulletData"));
            }
            var bullet = _bulletPool.receiveBullet();
            bullet.BulletPool = _bulletPool;
            bullet.transform.position = _barrel.transform.position;
        }
    }
}