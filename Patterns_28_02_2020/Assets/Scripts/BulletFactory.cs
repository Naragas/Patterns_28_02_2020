using UnityEngine;

namespace DefaultNamespace
{
    public class BulletFactory : IProjectilesFactory
    {


        public Projectile Create(BulletData _projectileData)
        {
            var bullet = Object.Instantiate(_projectileData.prefab).AddComponent<Bullet>();
            bullet._speed = _projectileData.Speed;
            bullet._damage = _projectileData.damage;

            return bullet;
        }
    }
}