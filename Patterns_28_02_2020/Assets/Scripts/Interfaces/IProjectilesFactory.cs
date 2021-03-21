using UnityEngine;

namespace DefaultNamespace
{
    public interface IProjectilesFactory
    {
        Projectile Create(BulletData _projectileData);
    }
}