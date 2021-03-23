using UnityEngine;

namespace DefaultNamespace
{
    public class ShootingSystem : IShooting
    {
        private readonly Bullet _bullet;
        private readonly Transform _barrel;
        private readonly float _force;

        
        //private BulletPool _bulletPool;
        

        public ShootingSystem(Bullet bullet, Transform barrel, float force)
        {
            _bullet = bullet;
            _barrel = barrel;
            _force = force;
        }

        public void Shoot()
        {
            var bullet = BulletPoolServiceLocatorCreation();

            //var bullet = BuilderBulletCreation();

            bullet.transform.position = _barrel.transform.position;
        }

        private static Bullet BulletPoolServiceLocatorCreation()
        {
            var _bulletPool = ServiceLocator.Resolve<BulletPool>();
            var bullet = _bulletPool.receiveBullet();
            bullet.BulletPool = _bulletPool;
            return bullet;
        }

        private static GameObject BuilderBulletCreation()
        {
            var bulletBilder = new BulletBilder();
            GameObject bullet = bulletBilder.Visual.Name("test").Physics.Script().BoxCollider2D();
            return bullet;
        }
    }
}