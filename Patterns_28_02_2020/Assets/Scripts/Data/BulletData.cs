using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "BulletData", menuName = "Data/Projectile/BulletData", order = 0)]
    public class BulletData : ScriptableObject
    {
        [Range(1f, 6f)] public float Speed;
        [Range(1f, 6f)] public float damage;
        public GameObject prefab;
    }
}