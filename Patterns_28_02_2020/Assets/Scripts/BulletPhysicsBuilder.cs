using UnityEngine;

namespace DefaultNamespace
{
    internal sealed class BulletPhysicsBuilder : BulletBilder
    {
        public BulletPhysicsBuilder(GameObject gameObject) : base(gameObject) {}

        public BulletPhysicsBuilder BoxCollider2D()
        {
            GetOrAddComponent<BoxCollider2D>();
            return this;
        }
        public BulletPhysicsBuilder Transform()
        {
            GetOrAddComponent<Transform>();
            return this;
        }

        public BulletPhysicsBuilder Script()
        {
            GetOrAddComponent<Bullet>();
            return this;
        }

        public BulletPhysicsBuilder Rigidbody2D(float mass)
        {
            var component = GetOrAddComponent<Rigidbody2D>();
            component.mass = mass;
            return this;
        }

    }
}